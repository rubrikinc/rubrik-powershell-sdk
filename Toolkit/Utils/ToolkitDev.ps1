<#
.SYNOPSIS
Utilities for RSC Toolkit development
#>
param (
    [switch]$Quiet
)

. "$PSScriptRoot\..\Private\FileUtils.ps1"
. "$PSScriptRoot\Import-ModuleFromOutputDir.ps1"

if ( ! $Quiet ) {
    Write-Host "`nRubrikSecurityCloud module imported from Output directory."
}

$tkdir = (Get-Item $PSScriptRoot).Parent
$Toolkit = [PSCustomObject]@{
    Dir        = $tkdir
    PublicDir  = Join-Path $tkdir "Public"
    PrivateDir = Join-Path $tkdir "Private"
    FormatDir  = Join-Path $tkdir "Format"
    SdkDir     = (Get-Item $tkdir).Parent
    OutputDir  = Join-Path $tkdir.Parent "Output" "Toolkit"

}
Remove-Variable -Name 'tkdir'

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
    $src = $srcInfo.FullName -Replace $Toolkit.SdkDir, "<SDK root>"
    $dst = $destFile -Replace $Toolkit.SdkDir, "<SDK root>"
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

    Foreach ($file in (Get-ChildItem -Path "$($toolkitDir.FormatDir)/*.ps*")) {
        if (Copy-ToolkitFileToOutputDir $file) {
            $fileCount++
        }
    }
    return $fileCount
}

function Update-RscToolkit {
    [CmdletBinding()] # To allow things like -Verbose
    Param()

    # Copy the toolkit files to the Output directory
    $copyCount = Copy-ToolkitToOutputDir
    Write-Output "Copied $copyCount files to Output directory."

    # Re-Import the module from the Output directory
    Import-ModuleFromOutputDir | Out-Null
    Write-Output "Imported module from Output directory."

    Get-RscToolkitStatus -Brief
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
    [CmdletBinding()] # To allow things like -Verbose
    Param(
        [switch]$Brief = $false,
        [string]$Filter = "*.ps*"

    )
    $tkDir = $Toolkit.Dir
    $tkOutputDir = $Toolkit.OutputDir
    if ( $Brief ) {
        $tkDir = $tkDir -Replace $Toolkit.SdkDir, "<SDK root>"
        $tkOutputDir = $tkOutputDir -Replace $Toolkit.SdkDir, "<SDK root>"
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

function ToolkitDevInfo() {
    Get-RscToolkitStatus -Brief
    Write-Host "`nToolkit development utilities:"
    Write-Host "------------------------------ " -ForegroundColor Green
    Write-Host "`n-> Run " -NoNewline
    Write-Host "Update-RscToolkit" -ForegroundColor Green -NoNewline
    Write-Host " to update the Output directory and re-import the module."
    Write-Host "-> Run " -NoNewline
    Write-Host "Get-RscToolkitStatus" -NoNewline -ForegroundColor Green
    Write-Host " to compare the source files with the Output directory."
}

if ( ! $Quiet ) {
    ToolkitDevInfo
}
