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

$SdkRoot = Join-Path -Path $PSScriptRoot -ChildPath '..\..' -Resolve

function updateModuleVersion {

    # Path to the PSD1 file
    $moduleFile = "$SdkRoot\RubrikSecurityCloud\RubrikSecurityCloud.PowerShell\RubrikSecurityCloud.psd1"

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

# Before updating the version, check if the new version is the same as the main
# branch version.
# Also, Test-RscSdkRelease will throw an error if the current release
# is corrupted (e.g. the main branch's version is not what's on the gallery).
$mainSdkVersion = & "$SdkRoot\Utils\admin\Test-RscSdkRelease.ps1"

if ($NewVersion -eq $mainSdkVersion -and -not $Force) {
    Write-Host "Error: The new version $NewVersion is the same as the main branch version." -ForegroundColor Red
    throw "New version is the same as the main branch version"
}

# Update PSD file
updateModuleVersion

# Update CHANGELOG.md
& "$SdkRoot\Utils\admin\Set-RscSdkLatestChangelog.ps1" -Version $NewVersion