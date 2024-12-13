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
    $OutputDir = Join-Path -Path $PSScriptRoot -ChildPath "..\..\Output"
    # If "Output" doesn't exist but "Output.Release" does, use that instead
    if (-not (Test-Path $OutputDir)) {
        $OutputDir = Join-Path -Path $PSScriptRoot -ChildPath "..\..\Output.Release"
    }
}
# Resolve "." and ".." in the path
$OutputDir = (Get-Item -Path $OutputDir).FullName
if (-not (Test-Path $OutputDir)) {
    Write-Error "Output directory not found."
    return
}

$tkdir = Resolve-Path "$PSScriptRoot/.."
$opdir = Join-Path -Path $tkdir -ChildPath "Operations" -Resolve
$Toolkit = [PSCustomObject]@{
    SdkDir     = Resolve-Path "$tkdir/.."
    Dir        = $tkdir
    PublicDir  = Join-Path -Path $tkdir -ChildPath "Public" -Resolve
    PrivateDir = Join-Path -Path $tkdir -ChildPath "Private" -Resolve
    FormatDir  = Join-Path -Path $tkdir -ChildPath "Format" -Resolve
    OpDefaultDir = Join-Path -Path $opdir -ChildPath "DEFAULT" -Resolve
    OpDetailDir  = Join-Path -Path $opdir -ChildPath "DETAIL" -Resolve
    OutputDir  = Join-Path -Path $OutputDir -ChildPath "Toolkit"
}
Remove-Variable -Name 'tkdir'
Remove-Variable -Name 'opdir'

# make sure the Output directories exists
New-Item -Path $Toolkit.OutputDir -ItemType Directory -Force | Out-Null
New-Item -Path $Toolkit.OpDefaultDir -ItemType Directory -Force | Out-Null
New-Item -Path $Toolkit.OpDetailDir -ItemType Directory -Force | Out-Null

. "$($Toolkit.PrivateDir)\FileUtils.ps1"

Write-Debug "ToolkitDev $($Toolkit)"

if ( $Connect ) {
    $params = @{
        ErrorAction = 'Stop'
        OutputDir = $OutputDir
    }
    if ($Quiet) {
        $params['Quiet'] = $true
    }
    . "$($Toolkit.SdkDir)\Utils\Import-RscModuleFromLocalOutputDir.ps1" @params    
    Connect-Rsc -ErrorAction Stop
}

function MatchingOutputFileName {
    param(
        [string]$SourceFileName
    )
    $srcInfo = Get-Item $SourceFileName -ErrorAction Stop
    # We only support copying files from the toolkit
    if ( -not $SourceFileName.ToLower().StartsWith($Toolkit.Dir.Path.ToLower()) ) {
        throw "File ${SourceFileName} is not under the toolkit directory $($Toolkit.Dir)."
    }
    # Path relative to the toolkit root
    $relativePath = $SourceFileName.Substring($Toolkit.Dir.Path.Length + 1)
    $dirs = Split-Path -Parent $relativePath
    $outDir = Join-Path -Path $Toolkit.OutputDir -ChildPath $dirs
    # Make sure the output directory exists
    New-Item -Path $outDir -ItemType Directory -Force | Out-Null
    $outPath = Join-Path -Path $outDir -ChildPath $srcInfo.Name
    Write-Debug "MatchingOutputFileName $SourceFileName --> $outPath"
    return $outPath
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
    Foreach ($file in (Get-ChildItem -Path "$($Toolkit.PublicDir)/*")) {
        if (Copy-ToolkitFileToOutputDir $file) {
            $fileCount++
        }
    }

    Foreach ($file in (Get-ChildItem -Path "$($Toolkit.PrivateDir)/*")) {
        if (Copy-ToolkitFileToOutputDir $file) {
            $fileCount++
        }
    }

    Foreach ($file in (Get-ChildItem -Path "$($Toolkit.FormatDir)/*")) {
        if (Copy-ToolkitFileToOutputDir $file) {
            $fileCount++
        }
    }

    Foreach ($file in (Get-ChildItem -Path "$($Toolkit.OpDefaultDir)/*")) {
        if (Copy-ToolkitFileToOutputDir $file) {
            $fileCount++
        }
    }

    Foreach ($file in (Get-ChildItem -Path "$($Toolkit.OpDetailDir)/*")) {
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
    . "$PSScriptRoot\..\..\Utils\Import-RscModuleFromLocalOutputDir.ps1" -OutputDir $OutputDir -ErrorAction Stop
    Write-Output "Imported module from Output directory."

    Get-RscToolkitStatus -Brief

    if ( ! $SkipTest ) {
        Test-RscToolkit
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

    #>
    [CmdletBinding()] # To allow things like -Verbose
    Param(
        [switch]$Brief = $false
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
    $srcDirs = @($Toolkit.PublicDir, $Toolkit.PrivateDir, $Toolkit.FormatDir, $Toolkit.OpDefaultDir, $Toolkit.OpDetailDir)
    $different = $false
    Get-ChildItem -Path $srcDirs | ForEach-Object {
        $sourceFile = $_.FullName
        $outputFile = MatchingOutputFileName $sourceFile
        $diff = (CompareFiles $sourceFile $outputFile) 
        $different = $different -or $diff -ne "same"

        if ( ! $Brief -or $diff -ne "same") {
            $diff = $diff -Replace "FileA", "Source file" -Replace "FileB", "Output file" -Replace "same", "Output file is up to date"
            $results += [PSCustomObject]@{
                Source =  $sourceFile.Substring($Toolkit.Dir.Path.Length + 1)
                Status = $diff
            }
        }
    }
    
    Write-Host ($results | Format-Table -AutoSize | Out-String)

    if ( ! $different ) {
        Write-Output "All toolkit files in Output are up to date."
    }

    if ( ! $Brief ) {
        $SystemInstalled = Get-Module -Name RubrikSecurityCloud -ListAvailable
        if ($SystemInstalled) {
            Write-Output "`nSystem-installed toolkit:"
            Get-Module -Name RubrikSecurityCloud -ListAvailable
            Write-Output "`nNote: the Toolkit dev workflow does not update the system-installed toolkit."
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

function New-ToolkitCmdlet {
    param (
        [Parameter(Mandatory=$true)]
        [string]$noun,

        [Parameter(Mandatory=$true)]
        [string]$MultipleQuery,

        [Parameter(Mandatory=$true)]
        [string]$GraphqlType,

        [string]$SingleQuery,

        # Future option for creating different cmdlet types from templates
        [Parameter()]
        [String]
        $CmdletType = "Get"
    )

    $templatePath = './toolkit/templates/GetTemplate.ps1'
    $testTemplatePath = './toolkit/templates/GetTemplate.Tests.ps1'
    $formatTemplatePath = './toolkit/templates/GetTemplate.Format.ps1xml'
    $outputScriptDir = './toolkit/public/'
    $outputFormatDir = './toolkit/Format/'
    $outputTestsDir = './toolkit/Tests/e2e/'
    
    # Read template content
    $templateContent = Get-Content -Path $templatePath -Raw
    $testTemplateContent = Get-Content -Path $testTemplatePath -Raw
    $formatTemplateContent = Get-Content -Path $formatTemplatePath -Raw
    
    # Replace placeholders
    # Ensure all occurrences of the placeholders are replaced
    $scriptContent = $templateContent -replace '__OBJECT_TYPE__', $noun
    $scriptContent = $scriptContent -replace '__MULTIPLE_QUERY__', $MultipleQuery
    $testContent = $testTemplateContent -replace '__OBJECT_TYPE__', $noun

    if ($SingleQuery) {
        $scriptContent = $scriptContent -replace '__SINGLE_QUERY__', $SingleQuery
    } else {
        $scriptContent = $scriptContent -replace '__SINGLE_QUERY__', ''
    }
    
    # Generate script filename
    $scriptFilename = "Get-$noun.ps1"
    $scriptOutputPath = Join-Path -Path $outputScriptDir -ChildPath $scriptFilename
    
    $testFilename = "Get-$noun.Tests.ps1"
    $testOutputPath = Join-Path -Path $outputTestsDir -ChildPath $testFilename

    # Write new script file
    Set-Content -Path $scriptOutputPath -Value $scriptContent
    Set-Content -Path $testOutputPath -Value $testContent

    # Create Format.ps1xml content
    $formatContent = $formatTemplateContent -replace '__GRAPHQL_TYPE__', $GraphqlType

    # Generate format filename
    $formatFilename = "${GraphqlType}.Format.ps1xml"
    $formatOutputPath = Join-Path -Path $outputFormatDir -ChildPath $formatFilename
    
    # Write the Format.ps1xml file
    Set-Content -Path $formatOutputPath -Value $formatContent
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
