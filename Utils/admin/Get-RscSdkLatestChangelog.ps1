<#
.SYNOPSIS
    Get the latest version entry from the CHANGELOG.md file.

.DESCRIPTION
    CHANGELOG.md must have the following format:
    - Starts with '# Changelog'
    - then a blank line
    - then the latest version entry '## Version <version>'

    This script reads the CHANGELOG.md file and extracts the latest version entry.
    For example, if the latest version entry is '## Version 1.9', the output will be:
    @{
        latestVersion = "1.9"
        latestVersionTag = "Version_1.9"
        latestVersionEntry = "..Text blurb for version 1.9.."
    }

#>
[CmdletBinding()]
param()

$changelogPath = Join-Path -Path $PSScriptRoot\..\.. -ChildPath "CHANGELOG.md"
$changelogContent = Get-Content -Path $changelogPath -Raw

# Normalize line endings
$changelogContent = $changelogContent -replace "`r`n", "`n"

# Regex to match the latest version entry
$hits = [regex]::Match($changelogContent, "(## Version .+?)(?=`n## Version |$)", 'Singleline')
if ($hits.Success -and $hits.Groups.Count -gt 1) {
    $latestVersionEntry = $hits.Groups[1].Value
    $latestVersionEntry = $latestVersionEntry -replace '## ', '' -replace "`r`n", "`n"
    $latestVersionTag = ($latestVersionEntry -split "`n")[0] -replace ' ', '_'
    $latestVersion = $latestVersionTag -replace 'Version_', ''

    # Output the findings
    [PSCustomObject]@{
        latestVersion = $latestVersion
        latestVersionTag = $latestVersionTag
        latestVersionEntry = $latestVersionEntry
    }
} else {
    Write-Error "Failed to find the latest version entry in CHANGELOG.md."
}
