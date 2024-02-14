$changelogPath = Join-Path -Path $PSScriptRoot\.. -ChildPath "CHANGELOG.md"
$changelogContent = Get-Content -Path $changelogPath -Raw

# Normalize line endings
$changelogContent = $changelogContent -replace "`r`n", "`n"

# Regex to match the latest version entry
$hits = [regex]::Match($changelogContent, "(## Version .+?)(?=`n## Version |$)", 'Singleline')
if ($hits.Success -and $hits.Groups.Count -gt 1) {
    $latestVersionEntry = $hits.Groups[1].Value
    $latestVersionEntry = $latestVersionEntry -replace '## ', '' -replace "`r`n", "`n"
    $latestVersionTag = ($latestVersionEntry -split "`n")[0] -replace ' ', '_'

    # Output the findings
    [PSCustomObject]@{
        latestVersionTag = $latestVersionTag
        latestVersionEntry = $latestVersionEntry
    }
} else {
    Write-Error "Failed to find the latest version entry in CHANGELOG.md."
}
