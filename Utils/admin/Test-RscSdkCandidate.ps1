<#
.SYNOPSIS
    Test if the current branch could be a candidate for a release.

.DESCRIPTION
Checks that:
- The current branch is not the 'main' branch.
- The latest version tag in the CHANGELOG.md file matches the module version in the psd1 file.
- The version tag is not already published on the GitHub repository.
- The version tag has the format "Version_<integer>.<integer>[<anything>]".
#>

$SdkRoot = Join-Path -Path $PSScriptRoot -ChildPath '..\..' -Resolve

# bail out if on the main branch
$sourceBranch = git rev-parse --abbrev-ref HEAD
if ($sourceBranch -eq 'main') {
    throw "You are on the 'main' branch. Start from the source branch."
}

# Get the latest changelog entry
$changelogLatest = & "$SdkRoot\Utils\admin\Get-RscSdkLatestChangelog.ps1"
if ( -Not $changelogLatest ) {
    throw "Failed to get the latest changelog entry."
}
$versionTag = $changelogLatest.latestVersionTag
$versionEntry = $changelogLatest.latestVersionEntry

# extract the module version from $versionTag
$changelogSemanticVersion = $versionTag -replace 'Version_', ''

# $versionTag must have the format "Version_<integer>.<integer>[<anything>]"
if ($versionTag -notmatch "^Version_\d+\.\d+.*$") {
    throw "Latest version '$changelogSemanticVersion' in ./CHANGELOG.md is invalid. It must have the format 'Version_<integer>.<integer>'."
}

# Check if the version tag matches the module version
$psd1SemanticVersion = (& "$SdkRoot\Utils\Get-RscSdkVersion.ps1")

Write-Host "Version in RubrikSecurityCloud.psd1: " -NoNewline
Write-Host $psd1SemanticVersion -ForegroundColor Cyan
Write-Host "Version in CHANGELOG.md:             " -NoNewLine
Write-Host $changelogSemanticVersion -ForegroundColor Cyan

if ( $changelogSemanticVersion -ne $psd1SemanticVersion ) {
    Write-Host @"

Version mismatch between

./CHANGELOG.md

and

./RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/RubrikSecurityCloud.psd1

The latest entry in ./CHANGELOG.md must have the format "Version M.m",
where "M.m" is the ModuleVersion field in 
./RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/RubrikSecurityCloud.psd1 .

./CHANGELOG.md shows:

$changelogSemanticVersion

./RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/RubrikSecurityCloud.psd1 shows:

$psd1SemanticVersion

"@ -ForegroundColor Yellow
    throw "Version mismatch. CHANGELOG: $changelogSemanticVersion, psd1: $psd1SemanticVersion."
}


# Make sure this version tag is not already published:
$existingTag = gh release list --json tagName --jq ".[] | select(.tagName == `"$versionTag`")"
if ($null -ne $existingTag) {
    $existingTag = $existingTag.Trim()
}
$isPublished = -not [string]::IsNullOrEmpty($existingTag)
Write-Host "Published on GitHub repo:            " -NoNewline
Write-Host $isPublished -ForegroundColor Cyan
if ( $isPublished ) {
    throw "Version tag $versionTag already exists in the GitHub repository."
}

Write-Host "`nThis branch is a candidate for a release." -ForegroundColor Green

[PSCustomObject]@{
    semanticVersion = $psd1SemanticVersion
    isPublished = $isPublished
    versionTag = $versionTag
    versionEntry = $versionEntry
}