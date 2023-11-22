<#
.SYNOPSIS
Import the Rubrik Security Cloud SDK module from the local Output directory.

.DESCRIPTION
`Import-Module RubrikSecurityCloud` imports the SDK from the installed package.
If you're developing the SDK, or if you want to work from source
instead of an installed package, you'll want to import the one that's in the
Output directory. 

Note: the script can also be called with `-System`, in which case
it'll import the one that's installed on the system.
#>

[CmdletBinding(
)]
param(

    [Parameter(
        Mandatory = $false,
        HelpMessage = "Import the module from the system instead of the local Output directory."
    )]
    [switch]$System,

    [Parameter(
        Mandatory = $false,
        HelpMessage = "The name of the module to import. Default is RubrikSecurityCloud."
    )]
    [string]$ModuleName = 'RubrikSecurityCloud'

)

if ($System) {
    Write-Output "Importing ${ModuleName} module from system."
    Import-Module $ModuleName -ErrorAction Stop -Force
}
else {
    $DllPath = Join-Path $PSScriptRoot "../Output/${ModuleName}.psd1"
    # Resolve "." and ".." in the path
    $DllPath = (Get-Item -Path $DllPath).FullName
    Write-Output "Importing ${ModuleName} module from local Output directory at ${DllPath}."
    Import-Module $DllPath -ErrorAction Stop -Force
}

if (Get-Command Get-RscCluster -ErrorAction SilentlyContinue) {
    Write-Output "RSC Toolkit loaded."
} else {
    Write-Error "RSC Toolkit not loaded."
}

$cmdletCount = (Get-Command -Module RubrikSecurityCloud | Measure-Object).Count
Write-Output "Imported ${cmdletCount} cmdlets from ${ModuleName}."

