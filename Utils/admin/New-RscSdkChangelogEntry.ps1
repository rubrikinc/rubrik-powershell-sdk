<#
.SYNOPSIS
Update CHANGELOG.md with a new empty version entry
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory = $false)]
    [string]$Version = "TBD",
    [Parameter(Mandatory = $false)]
    [switch]$Commit = $false
)

$latestVersion = (& "$PSScriptRoot\Get-RscSdkLatestChangelog.ps1").latestVersion

if ($Version -eq $latestVersion) {
    Write-Host "Error: The new version $Version is the same as the latest version." -ForegroundColor Red
    throw "New version is the same as the latest version"
}

$body = "`nNew Features:`n`nFixes:`n`nBreaking Changes:`n"
$changelogPath = Join-Path -Path $PSScriptRoot\..\.. -ChildPath "CHANGELOG.md"
$changelogContent = Get-Content -Path $changelogPath -Raw
$changelogContent = $changelogContent -replace "`r`n", "`n"
$changelogContent = $changelogContent -replace "(?<=# Changelog`n)", "`n## Version $Version`n$body"
Set-Content -Path $changelogPath -Value $changelogContent

if ($Commit) {
    git add $changelogPath
    git commit -m "Update changelog with new entry for version $Version"
}