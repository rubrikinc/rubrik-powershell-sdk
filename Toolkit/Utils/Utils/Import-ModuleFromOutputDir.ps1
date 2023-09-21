<#
.SYNOPSIS
Import the Rubrik SDK module from the Output directory.

.DESCRIPTION
`Import-Module RubrikSecurityCloud` imports the SDK from the installed package.
If you're developing the SDK, or if you want to work from source
instead of an installed package, you'll want to import the one that's in the
Output directory. 
#>
function Import-ModuleFromOutputDir {
    [CmdletBinding()]
    param(
        [string]$ModuleName = 'RubrikSecurityCloud',
        [ValidateScript({ Test-Path $_ -PathType Leaf })] $DllPath
    )

    $sdkDir = (Get-Item $PSScriptRoot).Parent.Parent

    # The path to the module is either given as a parameter, or it's in the Output directory.
    if (-not $DllPath) {
        $DllPath = Join-Path $sdkDir "Output" "${ModuleName}.psd1"
    }

    # If the module is already imported, remove it first.
    # If it's not installed, this will fail silently.
    Remove-Module -Name $ModuleName -ErrorAction 'SilentlyContinue'

    Import-Module $DllPath -ErrorAction Stop

    $cmdletCount = (Get-Command -Module RubrikSecurityCloud | Measure-Object).Count
    Write-Verbose "Imported ${cmdletCount} cmdlets from ${DllPath} module."
}

Import-ModuleFromOutputDir