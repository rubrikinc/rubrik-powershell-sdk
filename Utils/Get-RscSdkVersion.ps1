# Stop on error
$ErrorActionPreference = "Stop"

# Uncomment this to enable Write-Debug output
# $DebugPreference = "Continue"

# Path to the PSD1 file
$moduleFile = "$PSScriptRoot\..\RubrikSecurityCloud\RubrikSecurityCloud.PowerShell\RubrikSecurityCloud.psd1"

$moduleInfo = Import-PowerShellDataFile $moduleFile
return $moduleInfo.ModuleVersion
