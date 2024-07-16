<#
.SYNOPSIS
ADMIN USE ONLY. Update the GitHub repo's main branch, create a new release and publish it to the PowerShell Gallery.

.DESCRIPTION
ADMIN USE ONLY: this script updates the GitHub repo and the PowerShell
gallery and needs to be run by an admin.
Running it as a non-admin will not alter the repository and
will only show what would have been done.

NOTE: This script runs in dry mode by default unless -NotDry is given.
You can safely run New-RscSdkRelease.ps1
to see what would have been done without actually doing it.

This script will:
1. Get the latest changelog entry
2. Run Update-RscSdkMainBranch.ps1 to update the main branch
5. Commit the changes with the latest version entry as the commit message
6. Push the changes to the main branch
7. Create a new GitHub release

.EXAMPLE
.\Utils\New-RscSdkRelease.ps1
#>
param(
    [switch]$NotDry = $false
)

function RunIfNotDry {
    param(
        [ScriptBlock]$CodeBlock
    )

    # Check if the global variable $NotDry is set and not false
    if ($script:NotDry) {
        Write-Output "Run: $($CodeBlock.ToString())"
        try {
            # Execute the script block
            & $CodeBlock
        }
        catch {
            throw "Failed to execute $($CodeBlock.ToString()): $_"
        }
    }
    else {
        # Print the script block without executing
        Write-Output "Dry run: $($CodeBlock.ToString())"
    }
}

# Change to the root of the repository
Set-Location $PSScriptRoot\..

# bail out if not on the devel branch
$currentBranch = git rev-parse --abbrev-ref HEAD
if ($currentBranch -ne 'devel') {
    throw "You are not on the 'devel' branch. Current branch is '$currentBranch'."
}

# Get the latest changelog entry
$changelogScriptPath = ".\Utils\Get-RscSdkLatestChangelog.ps1"
$changelogLatest = & $changelogScriptPath
if ( -Not $changelogLatest ) {
    throw "Failed to get the latest changelog entry."
}
$versionTag = $changelogLatest.latestVersionTag
$versionEntry = $changelogLatest.latestVersionEntry

# $versionTag must have the format "Version_<integer>.<integer>"
if ($versionTag -notmatch "^Version_\d+\.\d+$") {
    throw "Latest version in ./CHANGELOG.md is invalid. It must have the format 'Version_<integer>.<integer>'."
}

# extract the module version from $versionTag
$changelogSemanticVersion = $versionTag -replace 'Version_', ''

# Check if the version tag matches the module version
$psd1SemanticVersion = (Import-PowerShellDataFile .\RubrikSecurityCloud\RubrikSecurityCloud.PowerShell\RubrikSecurityCloud.psd1).ModuleVersion

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

Write-Host "Latest version tag: " -NoNewline
Write-Host $versionTag -ForegroundColor Cyan
Write-Host "Latest version entry:"
Write-Host $versionEntry -ForegroundColor Cyan

# Make sure this version tag is not already published:
$existingTag = gh release list --json tagName --jq ".[] | select(.tagName == `"$versionTag`")"
if ($existingTag -ne "") {
    throw "Version tag $versionTag already exists in the GitHub repository."
}

# Update main branch
$CommitMessage = ""
RunIfNotDry {
    $script:CommitMessage = $versionEntry
}
.\Utils\Update-RscSdkMainBranch.ps1 -CommitMessage "$CommitMessage"

# Create a new GitHub release
RunIfNotDry {
    gh release create $versionTag -t $versionTag -n "$versionEntry"
}

# Publish the module to the PowerShell Gallery
if ($script:NotDry) {
    .\Utils\Publish-RscSdk.ps1 -NotDry
} else {
    .\Utils\Publish-RscSdk.ps1
}

# Prepare devel branch for further development
RunIfNotDry {
    git checkout devel
    Set-Location $PSScriptRoot\..
    .\Utils\New-RscSdkChangeLogEntry.ps1 -Commit
    git push origin devel
}

Write-Host "Done." -ForegroundColor Green
Write-Host "git status:"
git status
