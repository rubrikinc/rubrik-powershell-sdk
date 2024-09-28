param (
    [Parameter(Mandatory = $true)]
    [string]$NewVersion,
    [Parameter(Mandatory = $false)]
    [switch]$Force
)

# Stop on error
$ErrorActionPreference = "Stop"

# Uncomment this to enable Write-Debug output
# $DebugPreference = "Continue"

function updateModuleVersion {

    # Path to the PSD1 file
    $moduleFile = "$PSScriptRoot\..\RubrikSecurityCloud\RubrikSecurityCloud.PowerShell\RubrikSecurityCloud.psd1"

    # Read the existing psd1 file as text
    $psd1Content = Get-Content -Path $ModuleFile -Raw

    # Use regex to find and replace the ModuleVersion value
    $updatedContent = $psd1Content -replace 'ModuleVersion\s*=\s*''([^'']+)''', "ModuleVersion = '$NewVersion'"

    # Trim any extra newlines to prevent adding a new line
    $updatedContent = $updatedContent.TrimEnd()

    # Save the updated content back to the psd1 file
    Set-Content -Path $ModuleFile -Value $updatedContent

    Write-Host "Updated ModuleVersion to $NewVersion in $ModuleFile"
}

$mainSdkVersion = & "$PSScriptRoot\Test-RscSdkRelease.ps1"

if ($NewVersion -eq $mainSdkVersion -and -not $Force) {
    Write-Host "Error: The new version $NewVersion is the same as the main branch version." -ForegroundColor Red
    throw "New version is the same as the main branch version"
}

# Update PSD file
updateModuleVersion

# Update CHANGELOG.md
& "$PSScriptRoot\Set-RscSdkLatestChangelog.ps1" -Version $NewVersion