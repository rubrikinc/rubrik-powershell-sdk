<#
.SYNOPSIS
    Automatically compute the next release version and publish the SDK.

.DESCRIPTION
    Wrapper that drives the full release pipeline without manual version entry:

    0. Verify the current release state is coherent — PSGallery version,
       GitHub release tag, and main branch all agree (via Test-RscSdkRelease.ps1).
       Aborts if the current state is inconsistent.
       Then runs a build and test pre-flight (via Build-RscSdk.ps1).
    1. Compute the next version from VERSION.md, CHANGELOG.md, and the .psd1
       schema date (via Get-NextReleaseVersionNumber.ps1).
       Aborts if the next version matches the currently published version.
    2. Apply the version to the .psd1 and CHANGELOG.md
       (via Set-RscSdkVersion.ps1).
    3. Commit and push the version bump to the current branch.
    4. Validate the release candidate (via Test-RscSdkCandidate.ps1).
    5. Run the full release (via New-RscSdkRelease.ps1).
    6. Verify the published release (via Test-RscSdkRelease.ps1).

    Follows the release process defined in HOWTO_MAKE_A_RELEASE.md.
    Runs in dry-run mode by default. Pass -NotDry to execute for real.

.PARAMETER NotDry
    Execute the release. Without this switch the script prints every action
    it would take but makes no changes.

.EXAMPLE
    .\Utils\admin\Invoke-RscSdkAutoRelease.ps1

.EXAMPLE
    .\Utils\admin\Invoke-RscSdkAutoRelease.ps1 -NotDry
#>
param(
    [switch]$NotDry = $false
)

$ErrorActionPreference = "Stop"

$SdkRoot = Join-Path -Path $PSScriptRoot -ChildPath '..\..' -Resolve

function Step($message) {
    Write-Host "`n==> $message" -ForegroundColor Cyan
}

function RunIfNotDry([ScriptBlock]$block) {
    if ($script:NotDry) {
        Write-Host "Run: $($block.ToString().Trim())" -ForegroundColor Yellow
        & $block
    } else {
        Write-Host "Dry run: $($block.ToString().Trim())" -ForegroundColor DarkGray
    }
}

# ---------------------------------------------------------------------------
# 0. Verify current release state
# ---------------------------------------------------------------------------
Step "Verifying current release state"
& "$PSScriptRoot\Test-RscSdkRelease.ps1"
Write-Host "Current release state is coherent." -ForegroundColor Green

Step "Build and test pre-flight"
if ($NotDry) {
    & "$SdkRoot\Utils\Build-RscSdk.ps1"
    Write-Host "Build and tests passed." -ForegroundColor Green
} else {
    Write-Host "Dry run: skipping build and tests." -ForegroundColor DarkGray
}

# ---------------------------------------------------------------------------
# 1. Compute next version and compare with current
# ---------------------------------------------------------------------------
Step "Computing next release version"
$v = & "$PSScriptRoot\Get-NextReleaseVersionNumber.ps1"
$nextVersion = "$($v.Major).$($v.Minor).$($v.Schema)"
Write-Host "Next version:    $nextVersion"

$currentVersion = & "$SdkRoot\Utils\Get-RscSdkVersion.ps1"
Write-Host "Current version: $currentVersion"

if ($nextVersion -eq $currentVersion) {
    Write-Host "`nAbort: next version ($nextVersion) is the same as the current released version. Nothing to publish." -ForegroundColor Red
    exit 0
}

# ---------------------------------------------------------------------------
# 1b. Ensure "Schema Update" entry exists in the TBD changelog block
# ---------------------------------------------------------------------------
Step "Ensuring 'Schema Update' section in CHANGELOG.md TBD block"
RunIfNotDry {
    $changelogPath = Join-Path $SdkRoot "CHANGELOG.md"
    $raw = Get-Content $changelogPath -Raw
    $raw = $raw -replace "`r`n", "`n"
    $tbdMatch = [regex]::Match($raw, '## Version TBD\n(.*?)(?=\n## Version |\z)', 'Singleline')
    if ($tbdMatch.Success -and $tbdMatch.Value -notmatch 'Schema Update:') {
        $raw = $raw -replace '(## Version TBD\n+)', "`$1Schema Update:`n- Automatic schema update`n`n"
        Set-Content -Path $changelogPath -Value $raw -NoNewline
        Write-Host "Added 'Schema Update' section to TBD block." -ForegroundColor Green
    } else {
        Write-Host "'Schema Update' already present — no change needed." -ForegroundColor Green
    }
}

# ---------------------------------------------------------------------------
# 2. Apply version to .psd1 and CHANGELOG.md
# ---------------------------------------------------------------------------
Step "Applying version $nextVersion"
RunIfNotDry {
    & "$PSScriptRoot\Set-RscSdkVersion.ps1" -NewVersion $nextVersion
}

# ---------------------------------------------------------------------------
# 2b. Update VERSION.md with the computed minor and schema versions
# ---------------------------------------------------------------------------
Step "Updating VERSION.md to Minor=$($v.Minor), Schema=$($v.Schema)"
RunIfNotDry {
    $versionMdPath = Join-Path $SdkRoot "RubrikSecurityCloud\VERSION.md"
    $content = Get-Content $versionMdPath -Raw
    $content = $content -replace '(###\s+Minor Version:\s*)\d+', "`${1}$($v.Minor)"
    $content = $content -replace '(###\s+Schema Version:\s*)\d+', "`${1}$($v.Schema)"
    Set-Content -Path $versionMdPath -Value $content -NoNewline
}

# ---------------------------------------------------------------------------
# 3. Commit and push version bump
# ---------------------------------------------------------------------------
Step "Committing and pushing version bump"
RunIfNotDry {
    Set-Location $SdkRoot
    git add -u
    git commit -m "Bump version to $nextVersion"
    git push
}

# ---------------------------------------------------------------------------
# 4. Validate release candidate
# ---------------------------------------------------------------------------
Step "Validating release candidate"
& "$PSScriptRoot\Test-RscSdkCandidate.ps1"

# ---------------------------------------------------------------------------
# 5. Release
# ---------------------------------------------------------------------------
Step "Running release"
if ($NotDry) {
    & "$PSScriptRoot\New-RscSdkRelease.ps1" -NotDry
} else {
    & "$PSScriptRoot\New-RscSdkRelease.ps1"
}

# ---------------------------------------------------------------------------
# 6. Post-release verification
# ---------------------------------------------------------------------------
Step "Verifying published release"
RunIfNotDry {
    & "$PSScriptRoot\Test-RscSdkRelease.ps1"
}

if ($NotDry) {
    Write-Host "`nInvoke-RscSdkRelease complete. Version $nextVersion is live." -ForegroundColor Green
} else {
    Write-Host "`nDry run complete. Re-run with -NotDry to publish." -ForegroundColor Green
}
