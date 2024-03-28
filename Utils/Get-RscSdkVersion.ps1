# Change to the root of the repository
Set-Location $PSScriptRoot\..

# Stop on error
$ErrorActionPreference = "Stop"

# Uncomment this to enable Write-Debug output
# $DebugPreference = "Continue"

$moduleFile = ".\RubrikSecurityCloud\RubrikSecurityCloud.PowerShell\RubrikSecurityCloud.psd1"
$moduleInfo = Import-PowerShellDataFile $moduleFile
return $moduleInfo.ModuleVersion
```