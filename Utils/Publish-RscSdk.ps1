<#
.SYNOPSIS
    ADMIN USE ONLY. Publish the current state of the main branch to the PowerShell Gallery.

.DESCRIPTION
    ADMIN USE ONLY.
    This script publishes the current state of the main branch to the PowerShell Gallery.
    Running it as a non-admin will not publish the module.
    A publishing key file is required to publish the module, and it must be
    set in the RSC_PSGalleryKeyFile environment variable.

    You can safely run: .\Utils\Publish-RscSdk.ps1
    to see what would have been done without actually doing it because
    it runs in Dry mode by default.
    Run with -NotDry to actually publish the module.

    This script will:
    1. Assemble the module for publishing in the Output.Publish directory;
    2. Publish the module to the PowerShell Gallery.
#>
[CmdletBinding()]
param(
    [switch]$NotDry
)

# Stop on error
$ErrorActionPreference = "Stop"

# Uncomment this to enable Write-Debug output
# $DebugPreference = "Continue"

# Change to the root of the repository
Set-Location $PSScriptRoot\..

# bail out if not on the main branch
$currentBranch = git rev-parse --abbrev-ref HEAD
if ($currentBranch -ne 'main') {
    throw "You are not on the 'main' branch. Current branch is '$currentBranch'."
}

$publishDir = ".\Output.Publish"
# bail out if already there
if (Test-Path $publishDir) {
    throw "$publishDir already exists. Remove it first."
}

$releaseDir= ".\Output.Release"
# bail out if Output.Release is missing
if (-Not (Test-Path $releaseDir)) {
    throw "$releaseDir is missing. Run .\Utils\Build-RscSdk.ps1 -Release first."
}

# bail out if $Env:RSC_PSGalleryKeyFile is missing
if (-Not $Env:RSC_PSGalleryKeyFile) {
    throw "RSC_PSGalleryKeyFile is missing. Set it to the path of the key file."
}

# bail out if it doesn't exist
if (-Not (Test-Path $Env:RSC_PSGalleryKeyFile)) {
    throw "RSC_PSGalleryKeyFile=$Env:RSC_PSGalleryKeyFile does not exist."
}

$apiKey = (Get-Content $Env:RSC_PSGalleryKeyFile | ConvertFrom-Json).apiKey

# bail out if the key is empty
if (-Not $apiKey) {
    throw "RSC_PSGalleryKeyFile=$Env:RSC_PSGalleryKeyFile is empty."
}

# Assemble the module for publishing
$sdkVersion = .\Utils\Get-RscSdkVersion.ps1
Write-Host "Publishing version $sdkVersion to the PowerShell Gallery."
New-Item -Path $publishDir -ItemType Directory
$galleryDir = Join-Path $publishDir RubrikSecurityCloud
New-Item -Path $galleryDir -ItemType Directory
$targetDir = Join-Path $galleryDir $sdkVersion
Copy-Item -Path $releaseDir -Destination $targetDir -Recurse

# Publish the module
if ($NotDry) {
    Publish-Module -Path $galleryDir -NuGetApiKey $apiKey -Verbose
}
else {
    Write-Host "Dry run:"
    Publish-Module -Path $galleryDir -NuGetApiKey $apiKey -Verbose -WhatIf
}
