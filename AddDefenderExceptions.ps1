# Run this script as Administrator
# powershell -ExecutionPolicy Bypass -File "C:\RSL\Rookie\AddDefenderExceptions.ps1"


################################################################
## Auto Elevate to Admin if not running as admin
################################################################

# Get the ID and security principal of the current user account
$WindowsID = [System.Security.Principal.WindowsIdentity]::GetCurrent()
$WindowsPrincipal = New-Object System.Security.Principal.WindowsPrincipal ($WindowsID)

# Get the security principal for the Administrator role
$AdminRole = [System.Security.Principal.WindowsBuiltInRole]::Administrator

# Check to see if we are currently running "as Administrator"
if ($WindowsPrincipal.IsInRole($AdminRole)) {
	# We are running "as Administrator" - so change the title and background color to indicate this
	$Host.UI.RawUI.WindowTitle = $myInvocation.MyCommand.Definition + " (Elevated)"
	$Host.UI.RawUI.BackgroundColor = "DarkBlue"
	Clear-Host
} else {
	# We are not running "as Administrator" - so relaunch as administrator
	# Create a new process object that starts PowerShell
	$NewProcess = New-Object System.Diagnostics.ProcessStartInfo "PowerShell";
	# Specify the current script path and name as a parameter
	$NewProcess.Arguments = $myInvocation.MyCommand.Definition;
	# Indicate that the process should be elevated
	$NewProcess.Verb = "runas";
	# Start the new process
	[System.Diagnostics.Process]::Start($NewProcess);
	# Exit from the current unelevated process
	exit
}

write-host "Important: Run this script from the directory root with which Rookie will be run to exclude"
Start-Sleep -s 5

    try {
        Add-MpPreference -ExclusionPath $PSScriptRoot -ErrorAction Stop
        Write-Host "Successfully added exclusion for: $PSScriptRoot " -ForegroundColor Green
    }
    catch {
        Write-Host "Failed to add exclusion for: $PSScriptRoot " -ForegroundColor Red
        Write-Host "Error: $_" -ForegroundColor Red
	Start-Sleep -s 5
	Pause
    }


# Verify the exclusions
Write-Host "`nCurrent exclusions:" -ForegroundColor Cyan
Get-MpPreference | Select-Object -ExpandProperty ExclusionPath | Where-Object { $_ -like $PSScriptRoot }


Start-Sleep -s 5
