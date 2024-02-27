<#
.SYNOPSIS
Import the Rubrik Security Cloud SDK module from the local Output directory.

.DESCRIPTION
`Import-Module RubrikSecurityCloud` imports the SDK from the installed package.
If you're developing the SDK, or if you want to work from source
instead of an installed package, you'll want to import the one that's in the
Output directory. 

Note1: If there's no Output directory, it'll look for Output.Release instead.

Note2: the script can also be called with `-System`, in which case
it'll import the one that's installed on the system.
#>

[CmdletBinding(
)]
param(
    [Parameter(
        Mandatory = $false,
        HelpMessage = "No output if set"
    )]
    [switch]$Quiet,

    [Parameter(
        Mandatory = $false,
        HelpMessage = "Import the module from the system instead of the local Output directory."
    )]
    [switch]$System,

    [Parameter(
        Mandatory = $false,
        HelpMessage = "The name of the module to import. Default is RubrikSecurityCloud."
    )]
    [string]$ModuleName = 'RubrikSecurityCloud',

    [Parameter(
        Mandatory = $false,
        HelpMessage = "The local output directory to import the module from. Default is '../Output'.",
        ValueFromPipeline = $true
    )]
    [string]$OutputDir = ""
)

function Write-OutputIfNotQuiet {
    param(
        [string]$Message
    )
    if (-not $Quiet) {
        Write-Output $Message
    }
}

if ($System) {
    Write-OutputIfNotQuiet "Importing ${ModuleName} module from system."
    Import-Module $ModuleName -ErrorAction Stop -Force
}
else {
    if ( -not $OutputDir ) {
        $OutputDir = Join-Path $PSScriptRoot "../Output"
        # If "Output" doesn't exist but "Output.Release" does, use that instead
        if (-not (Test-Path $OutputDir)) {
            $OutputDir = Join-Path $PSScriptRoot "../Output.Release"
        }
    }
    if (-not (Test-Path $OutputDir)) {
        Write-Error "Output directory not found."
        return
    }
    # Resolve "." and ".." in the path
    $OutputDir = (Get-Item -Path $OutputDir).FullName
    $DllPath = Join-Path $OutputDir "${ModuleName}.psd1"
    Write-OutputIfNotQuiet "Importing ${ModuleName} module from ${DllPath}."
    Import-Module $DllPath -ErrorAction Stop -Force
}

# We use Get-RscCluster as a canary to check if the module was imported
if (Get-Command Get-RscCluster -ErrorAction SilentlyContinue) {
    Write-OutputIfNotQuiet "RSC Toolkit loaded."
} else {
    Write-Error "RSC Toolkit not loaded."
}

$cmdletCount = (Get-Command -Module RubrikSecurityCloud | Measure-Object).Count
Write-OutputIfNotQuiet "Imported ${cmdletCount} cmdlets and functions from ${ModuleName}."

