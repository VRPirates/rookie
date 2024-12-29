# Run this script as Administrator
# powershell -ExecutionPolicy Bypass -File "C:\RSL\Rookie\AddDefenderExceptions.ps1"

if (-NOT ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator")) {
    Write-Warning "Please run this script as Administrator!"
    exit
}

$paths = @(
    "C:\RSL",
    "C:\RSL\Rookie",
    "C:\RSL\Rookie\rclone",
    "C:\RSL\Rookie\Sideloader Launcher.exe",
    "C:\RSL\Rookie\AndroidSideloader*.exe",
    "C:\RSL\Rookie\rclone\rclone.exe"
)

foreach ($path in $paths) {
    try {
        Add-MpPreference -ExclusionPath $path -ErrorAction Stop
        Write-Host "Successfully added exclusion for: $path" -ForegroundColor Green
    }
    catch {
        Write-Host "Failed to add exclusion for: $path" -ForegroundColor Red
        Write-Host "Error: $_" -ForegroundColor Red
    }
}

# Verify the exclusions
Write-Host "`nCurrent exclusions:" -ForegroundColor Cyan
Get-MpPreference | Select-Object -ExpandProperty ExclusionPath | Where-Object { $_ -like "C:\RSL*" }
