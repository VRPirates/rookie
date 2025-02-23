$rookiePath = "C:\RSL\Rookie"
$platformTools = Join-Path $rookiePath "platform-tools"
$apiUrl = "https://api.github.com/repos/VRPirates/rookie/releases/latest"

# Installation check

if (Test-Path -Path "$rookiePath\*") {
    Write-Host "Rookie directory already exists at '$rookiePath'"
    $response = Read-Host "Reinstall? [y/n] (this will remove the directory and all of its content)"
    
    if (($response.StartsWith('n')) -or ($response.StartsWith('N'))) {
        Write-Host "Exiting..."
        return
    }

    rm $rookiePath -r
}

Write-Host "Fetching latest Rookie release."

New-Item -ItemType Directory -Path $rookiePath -Force | Out-Null

# Install Rookie

$releaseInfo = Invoke-RestMethod -Uri $apiUrl -Method Get
$version = $releaseInfo.tag_name
$downloadUrl = $releaseInfo.assets[0].browser_download_url

Write-Host "Installing Rookie $version to '$rookiePath'"

$outputPath = Join-Path $rookiePath "AndroidSideloader.exe"
Invoke-WebRequest -Uri $downloadUrl -OutFile $outputPath

# Give the AV a second to detect the file
Start-Sleep -Seconds 1

# Check if the ops got it
if (-not (Test-Path -Path $outputPath)) {
    Write-Host "Failed to find Rookie. This likely means it has been removed by your Antivirus. Please create a folder exclusion for it and try again."
    Write-Host "If you're not sure how, please watch this YouTube video for Windows Defender: https://www.youtube.com/watch?v=BonLkFNnO9w&t=54s"
    Write-Host "Note: Turning your AV off is not only not going to work in the long-run, but puts your system at risk of real malware. A folder exclusion will allow Rookie to run."

    return
}

Write-Host "Rookie has been installed to $outputPath successfully!"
explorer.exe $rookiePath