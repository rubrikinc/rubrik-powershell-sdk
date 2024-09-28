<#
.SYNOPSIS
    Updates the latest version entry in the CHANGELOG.md file.

.DESCRIPTION
    This script updates the latest version entry in the CHANGELOG.md file.
    It takes a -Version parameter, replacing the current version in the first version entry.
    For example, if the provided version is '1.10', the latest version entry will be updated to '## Version 1.10'.

.PARAMETER Version
    The new version number to set as the latest version entry.

#>
[CmdletBinding()]
param (
    [Parameter(Mandatory = $true)]
    [string]$Version
)

# Path to CHANGELOG.md
$changelogPath = Join-Path -Path $PSScriptRoot\.. -ChildPath "CHANGELOG.md"

# Ensure the changelog file exists
if (-not (Test-Path -Path $changelogPath)) {
    Write-Error "CHANGELOG.md not found at path: $changelogPath"
    return
}

# Read the changelog file
$changelogContent = Get-Content -Path $changelogPath -Raw

# Normalize line endings to Unix style
$changelogContent = $changelogContent -replace "`r`n", "`n"

# Regex to match the latest version entry
$hits = [regex]::Match($changelogContent, "(## Version .+?)(?=`n## Version |$)", 'Singleline')
if ($hits.Success -and $hits.Groups.Count -gt 1) {
    $latestVersionTitle = ($hits.Groups[1].Value -split "`n")[0]
    Write-Host "latestVersionTitle: $latestVersionTitle"
    $newVersionTitle = "## Version $Version"

    # Replace the old version entry with the new version entry in the content
    $updatedContent = $changelogContent -replace [regex]::Escape($latestVersionTitle), $newVersionTitle

    # Write the updated content back to CHANGELOG.md
    Set-Content -Path $changelogPath -Value $updatedContent.TrimEnd()

    Write-Host "Successfully updated CHANGELOG.md to Version $Version."
} else {
    Write-Error "Failed to find the latest version entry in CHANGELOG.md."
}
