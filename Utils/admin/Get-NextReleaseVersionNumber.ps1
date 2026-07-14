param(
    [string]$VersionFile   = (Join-Path $PSScriptRoot "..\..\RubrikSecurityCloud\VERSION.md"),
    [string]$ChangelogFile = (Join-Path $PSScriptRoot "..\..\CHANGELOG.md"),
    [string]$Psd1File      = (Join-Path $PSScriptRoot "..\..\RubrikSecurityCloud\RubrikSecurityCloud.PowerShell\RubrikSecurityCloud.psd1")
)
$ErrorActionPreference = "Stop"

$versionFile   = $VersionFile
$changelogFile = $ChangelogFile
$psd1File      = $Psd1File

# Read a numeric field from VERSION.md (e.g. "### Minor Version: 18")
function ParseVersionField($lines, $label) {
    $line = $lines | Where-Object { $_ -match "###\s+$label\s*:\s*(\d+)" } | Select-Object -First 1
    if (-not $line) {
        throw "Could not find '$label' in $versionFile"
    }
    $null = $line -match '(\d+)\s*$'
    return [int]$Matches[1]
}

# Reads the schema date (YYYYMMDD) from the Description field in the .psd1.
# Jenkins updates the description to e.g. "... GraphQL schema version: v20260601-47 ."
function GetSchemaVersionFromPsd1($psd1File) {
    $moduleInfo = Import-PowerShellDataFile $psd1File
    $desc = $moduleInfo.Description
    if ($desc -notmatch 'GraphQL schema version:\s*v?(\d{8})') {
        throw "Could not extract schema version from Description in $psd1File"
    }
    return [int]$Matches[1]
}

# Returns the Major version number from the last released entry in CHANGELOG.md
# (i.e. the first "## Version X.Y.Z" line that is not TBD).
function GetLastReleasedMajor($changelogFile) {
    $line = Get-Content $changelogFile |
        Where-Object { $_ -match '^## Version (\d+)\.\d+\.\d+' } |
        Select-Object -First 1
    if (-not $line) {
        throw "Could not find a released version entry in $changelogFile"
    }
    $null = $line -match '^## Version (\d+)'
    return [int]$Matches[1]
}

# Returns the Minor version number from the last released entry in CHANGELOG.md
# (i.e. the first "## Version X.Y.Z" line that is not TBD).
function GetLastReleasedMinor($changelogFile) {
    $line = Get-Content $changelogFile |
        Where-Object { $_ -match '^## Version \d+\.(\d+)\.\d+' } |
        Select-Object -First 1
    if (-not $line) {
        throw "Could not find a released version entry in $changelogFile"
    }
    $null = $line -match '^## Version \d+\.(\d+)'
    return [int]$Matches[1]
}

# Check whether the "## Version TBD" block in CHANGELOG.md has any real entries
# (non-empty, non-"None") under New Features, Fixes, or Breaking Changes.
function HasChangelogEntries($changelogFile) {
    $content = Get-Content $changelogFile -Raw
    $content = $content -replace "`r`n", "`n"

    # Extract only the TBD block (everything up to the next ## Version heading)
    $match = [regex]::Match($content, '## Version TBD\n(.+?)(?=\n## Version |\z)', 'Singleline')
    if (-not $match.Success) {
        return $false
    }
    $tdBlock = $match.Groups[1].Value

    foreach ($section in @('New Features', 'Fixes', 'Breaking Changes')) {
        $secMatch = [regex]::Match(
            $tdBlock,
            "${section}:\n(.*?)(?=\n[A-Z][^:]+:|\z)",
            'Singleline'
        )
        if (-not $secMatch.Success) { continue }

        $body = $secMatch.Groups[1].Value.Trim()
        if ($body -and $body -notmatch '^\s*None\s*$') {
            return $true
        }
    }
    return $false
}

$versionLines      = Get-Content $versionFile
$major             = ParseVersionField $versionLines "Major Version"
$schema            = GetSchemaVersionFromPsd1 $psd1File
$lastReleasedMajor = GetLastReleasedMajor $changelogFile
$minor             = GetLastReleasedMinor $changelogFile

if ($major -gt $lastReleasedMajor) {
    # Major version bumped — reset Minor to 0
    $minor = 0
} elseif (HasChangelogEntries $changelogFile) {
    $minor++
}

return [PSCustomObject]@{
    Major  = $major
    Minor  = $minor
    Schema = $schema
}
