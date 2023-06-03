<#
.SYNOPSIS
Import the Rubrik SDK module from the Output directory if not installed.

.DESCRIPTION
Typically a `Import-Module RubrikSecurityCloud` is sufficient to import the
Rubrik SDK module, because it'll import the one that's installed on the system.

However, if you're developing the SDK, or if you want to work from source
instead of an installed package, you'll want to import the one that's in the
Output directory. This script will first try to import the module normally,
and if missing, then import the local one in the Output directory.
If the -Local parameter is given, it forces the module to be imported from
the Output directory.

.PARAMETER Local
If given, the module will be imported from the local Output directory.
If not given, the module will be imported from the installed package, or if missing, from the local Output directory.
#>
[CmdletBinding()]
param(
    [switch]$Local,
    [string]$ModuleName = 'RubrikSecurityCloud',
    [ValidateScript({ Test-Path $_ -PathType Leaf })] $DllPath
)

# The path to the module is either given as a parameter, or it's in the Output directory.
if (-not $DllPath) {
    $DllPath = Join-Path $PSScriptRoot "../Output/${ModuleName}.psd1"
}

# If the module is installed on the system, remove it first.
# If it's not installed, this will fail silently.
Remove-Module -Name $ModuleName -ErrorAction 'SilentlyContinue'

if ($Local) {
    Write-Verbose "Importing ${ModuleName} module from local Output directory."
    Import-Module $DllPath -ErrorAction Stop
}
else {

    try {
        Import-Module $ModuleName -ErrorAction Stop
    }
    catch {
        Write-Verbose "${ModuleName} module not on path. Importing from local directory."
        Import-Module $DllPath -ErrorAction Stop
    }
}

$cmdletCount = (Get-Command -Module RubrikSecurityCloud | Measure-Object).Count
Write-Verbose "Imported ${cmdletCount} cmdlets from ${ModuleName} module."

# 
# For Alpha release:
#
# REMOVE AFTER ALPHA RELEASE
Get-ChildItem -Path ${PSScriptRoot}/../RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Public/*.psm1 | Import-Module
#
#
#
