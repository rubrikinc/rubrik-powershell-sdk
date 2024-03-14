<#
.SYNOPSIS
Utilities for RSC Toolkit development

.DESCRIPTION
This script provides utility functions for developing the RSC Toolkit.
Bring these utilities into your PowerShell session by running:
    . .\ToolkitDev.ps1

The functions are:

- Update-RscToolkit: Copies the toolkit files to the Output directory and re-imports the module.
- Get-RscToolkitStatus: Compares the source files with the Output directory.
- Test-RscToolkit: Runs the toolkit tests.

see https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/Toolkit/Docs/TOOLKIT_DEVELOPER_MANUAL.md for more information.

.PARAMETER Quiet
If set, the intro message is suppressed.

.PARAMETER Connect
If set, Connect-Rsc is called at the beginning of the script.
#>
param (
    [switch]$Quiet,
    [switch]$Connect,
    [string]$OutputDir = ""
)

if ( -Not $OutputDir ) {
    $OutputDir = Join-Path $PSScriptRoot "..\..\Output"
    # If "Output" doesn't exist but "Output.Release" does, use that instead
    if (-not (Test-Path $OutputDir)) {
        $OutputDir = Join-Path $PSScriptRoot "..\..\Output.Release"
    }
}
# Resolve "." and ".." in the path
$OutputDir = (Get-Item -Path $OutputDir).FullName
if (-not (Test-Path $OutputDir)) {
    Write-Error "Output directory not found."
    return
}

$tkdir = (Get-Item $PSScriptRoot).Parent
$Toolkit = [PSCustomObject]@{
    SdkDir     = (Get-Item $tkdir).Parent
    Dir        = $tkdir
    PublicDir  = Join-Path $tkdir "Public"
    PrivateDir = Join-Path $tkdir "Private"
    FormatDir  = Join-Path $tkdir "Format"
    OutputDir  = Join-Path $OutputDir "Toolkit"
}
Remove-Variable -Name 'tkdir'

. "$($Toolkit.PrivateDir)\FileUtils.ps1"
$params = @{
    OutputDir = $OutputDir
}
if ($Quiet) {
    $params['Quiet'] = $true
}
. "$($Toolkit.SdkDir)\Utils\Import-RscModuleFromLocalOutputDir.ps1" @params


if ( $Connect ) {
    Connect-Rsc
}

function MatchingOutputFileName {
    param(
        [string]$SourceFileName
    )
    $srcInfo = Get-Item $SourceFileName -ErrorAction Stop
    $sourceDir = ($srcInfo).Directory.Name
    # We only support copying files from Public, Private, and Format
    if ($sourceDir -notin @("Public", "Private", "Format")) {
        throw "Unsupported source directory: ${sourceDir}"
    }
    return Join-Path $Toolkit.OutputDir $sourceDir $srcInfo.Name
}

function Copy-ToolkitFileToOutputDir {
    param (
        [string]$SourceFile
    )
    $srcInfo = Get-Item $SourceFile -ErrorAction Stop
    $destFile = MatchingOutputFileName $SourceFile
    $copied = CopyFileIfDifferent $srcInfo.FullName $destFile
    $escapedSdkDir = [regex]::Escape($Toolkit.SdkDir)
    $src = $srcInfo.FullName -Replace $escapedSdkDir, "<SDK root>"
    $dst = $destFile -Replace $escapedSdkDir, "<SDK root>"
    if ($copied) {
        Write-Host "Copied $src to $dst."
        return $true
    }
    else {
        Write-Verbose "Skipped: $src."
        return $false
    }
}

function Copy-ToolkitToOutputDir {
    [CmdletBinding()] # To allow things like -Verbose
    Param()

    $fileCount = 0
    Foreach ($file in (Get-ChildItem -Path "$($Toolkit.PublicDir)/*.ps*")) {
        if (Copy-ToolkitFileToOutputDir $file) {
            $fileCount++
        }
    }

    Foreach ($file in (Get-ChildItem -Path "$($Toolkit.PrivateDir)/*.ps*")) {
        if (Copy-ToolkitFileToOutputDir $file) {
            $fileCount++
        }
    }

    Foreach ($file in (Get-ChildItem -Path "$($Toolkit.FormatDir)/*.ps*")) {
        if (Copy-ToolkitFileToOutputDir $file) {
            $fileCount++
        }
    }
    return $fileCount
}

function Update-RscToolkit {
    <#
    .SYNOPSIS
    Update the RSC Toolkit in the Output directory and re-import the module.

    .DESCRIPTION
    This function copies the toolkit files to the Output directory and re-imports the module.
    It also runs the tests by default, but you can skip them with the -SkipTest switch.
    #>
    [CmdletBinding()] # To allow things like -Verbose
    Param(
        [switch]$SkipTest
    )

    # Copy the toolkit files to the Output directory
    $copyCount = Copy-ToolkitToOutputDir
    Write-Output "Copied $copyCount files to Output directory."

    # Re-Import the module from the Output directory
    . "$PSScriptRoot\..\..\Utils\Import-RscModuleFromLocalOutputDir.ps1" -OutputDir $OutputDir
    Write-Output "Imported module from Output directory."

    Get-RscToolkitStatus -Brief

    if ( ! $SkipTest ) {
        Test-RscToolkit
    }
}

function DetermineSystemInstalledToolkitLocation {
    # If the module is already imported, remove it first.
    # If it's not installed, this will fail silently.
    Remove-Module -Name RubrikSecurityCloud -ErrorAction 'SilentlyContinue'
        
    # Attempt to import the system-installed module
    try {
        Import-Module RubrikSecurityCloud -ErrorAction Stop | Out-Null
    
        # We assume Get-RscCluster is still a thing
        return [System.IO.Path]::GetDirectoryName((Get-Command Get-RscCluster).ScriptBlock.File)
    }
    catch {
        return $null
    }
}

function Get-RscToolkitStatus {
    <#
    .SYNOPSIS
    Compare the source files with the Output directory.

    .DESCRIPTION
    This function compares the source files with the Output directory.
    It also checks if the system-installed toolkit is present.

    .PARAMETER Brief
    If set, the source and output directories are abbreviated to "<SDK root>".

    .PARAMETER Filter
    A filter to apply to the source files. Default is "*.ps*".
    #>
    [CmdletBinding()] # To allow things like -Verbose
    Param(
        [switch]$Brief = $false,
        [string]$Filter = "*.ps*"

    )
    $tkDir = $Toolkit.Dir
    $tkOutputDir = $Toolkit.OutputDir
    if ( $Brief ) {
        $tkDir = $tkDir -Replace [regex]::Escape($Toolkit.SdkDir), "<SDK root>"
        $tkOutputDir = $tkOutputDir -Replace [regex]::Escape($Toolkit.SdkDir), "<SDK root>"
    }
    Write-Host "`nToolkit status:"
    Write-Host "---------------`n " -ForegroundColor Green
    Write-Host @"
SDK root: $($Toolkit.SdkDir)
Source directory: $tkDir
Output directory: $tkOutputDir
"@

    # Compare source files with destination files
    $results = @()
    $srcDirs = @($Toolkit.PublicDir, $Toolkit.PrivateDir, $Toolkit.FormatDir)
    $different = $false
    Get-ChildItem -Path $srcDirs -Filter $Filter | ForEach-Object {
        $sourceFile = $_
        $outputFile = MatchingOutputFileName $sourceFile
        $diff = (CompareFiles $sourceFile $outputFile) 
        $different = $different -or $diff -ne "same"

        if ( ! $Brief -or $diff -ne "same") {
            $diff = $diff -Replace "FileA", "Source file" -Replace "FileB", "Output file" -Replace "same", "Output file is up to date"
    
            $results += [PSCustomObject]@{
                Source = Join-Path $sourceFile.Directory.Name $sourceFile.Name
                Status = $diff
            }
        }
    }
    
    Write-Host ($results | Format-Table -AutoSize | Out-String)

    if ( ! $different ) {
        Write-Output "All toolkit files in Output are up to date."
    }

    if ( ! $Brief ) {
        $SystemInstalled = DetermineSystemInstalledToolkitLocation
        if ($SystemInstalled) {
            Write-Output @"

System-installed toolkit: $SystemInstalled
Note: the Toolkit dev workflow does not update the system-installed toolkit.
"@
        }
        else {
            Write-Output "`nNo system-installed toolkit found."
        }
    }

}

function Test-RscToolkit {
    <#
    .SYNOPSIS
    Run the RSC Toolkit tests.
    #>
    $scriptPath = Join-Path -Path $PSScriptRoot -ChildPath "..\..\Utils\Test-RscSdk.ps1"
    & $scriptPath -SkipCoreTests
}

function ToolkitDevInfo() {
    Get-RscToolkitStatus -Brief
    Write-Host "`n$([char]::ConvertFromUtf32(0x1F6E0))  Toolkit development utilities:"
    Write-Host "--------------------------------- " -ForegroundColor Green
    Write-Host "`n-> Run " -NoNewline
    Write-Host "Update-RscToolkit" -ForegroundColor Green -NoNewline
    Write-Host " to update the Output directory and re-import the module."
    Write-Host "-> Run " -NoNewline
    Write-Host "Get-RscToolkitStatus" -NoNewline -ForegroundColor Green
    Write-Host " to compare the source files with the Output directory."
}

if ( -Not $Quiet ) {
    ToolkitDevInfo
}
