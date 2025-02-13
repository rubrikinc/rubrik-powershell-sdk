<#
.SYNOPSIS
Build the Rubrik Security Cloud SDK.

.DESCRIPTION
This script

- runs Clean-RscSdk.ps1 to remove any previous build artifacts.
- builds the Rubrik Security Cloud SDK and copies the output
  to the Output/ directory.

By default, the script will build the Debug version of the SDK.
You can build the Release version by passing -Release.
Note that the Release build is copied to the Output.Release/ directory
instead of Output/.
#>
param(
    [switch]$NoClean = $false,
    [switch]$Release = $false,
    [switch]$NoDocs = $false
)

# Change to the root of the repository
Set-Location $PSScriptRoot\.. 

if (-Not $NoClean) {
    .\Utils\Clean-RscSdk.ps1
}

$OutputDir = ".\Output"
$ProjectDir = ".\RubrikSecurityCloud\RubrikSecurityCloud.PowerShell"
$ProjectOutputDir = "$ProjectDir\bin\Debug"

if ($Release) {
    $OutputDir = ".\Output.Release"
    $ProjectOutputDir = "$ProjectDir\bin\Release"
}

# Stop on error
$ErrorActionPreference = "Stop"

# Make sure we have dotnet
try {
    $dotnetVersion = dotnet --version
    Write-Host "dotnet version: $dotnetVersion"
} catch {
    Write-Error "Failed to execute 'dotnet --version'. Please ensure .NET SDK is correctly installed and accessible."
    exit 1
}

# Build the project
$buildCommand = if ($Release) {
    "dotnet build --configuration Release /p:GeneratePSDocs=true $ProjectDir"
} elseif ($NoDocs) {
    "dotnet build $ProjectDir"
} else {
    "dotnet build /p:GeneratePSDocs=true $ProjectDir"
}

Invoke-Expression $buildCommand

if ($LASTEXITCODE -ne 0 ) {
    Write-Error "dotnet build failed."
    exit $LASTEXITCODE
}

# Copy the output to the output directory
Copy-Item -Recurse -Force $ProjectOutputDir $OutputDir
$helpXmlPath = "$OutputDir\net6.0\RubrikSecurityCloud.PowerShell.dll-Help.xml"
if (Test-Path $helpXmlPath) {
    Copy-Item $helpXmlPath $OutputDir\net461\
} else {
    Write-Warning "Documentation XML file not found. Skipping copy."
}

