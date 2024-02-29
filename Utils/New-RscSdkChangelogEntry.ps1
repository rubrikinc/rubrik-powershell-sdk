# Update CHANGELOG.md with a new empty version entry
$changelogPath = Join-Path -Path $PSScriptRoot\.. -ChildPath "CHANGELOG.md"
$changelogContent = Get-Content -Path $changelogPath -Raw
$changelogContent = $changelogContent -replace "`r`n", "`n"
$changelogContent = $changelogContent -replace "(?<=# Changelog`n)", "`n## ~ Upcoming Version ~`n`nNew Features:`n`nFixes:`n`nBreaking Changes:`n"
Set-Content -Path $changelogPath -Value $changelogContent