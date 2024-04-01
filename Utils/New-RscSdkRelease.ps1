<#
.SYNOPSIS
ADMIN USE ONLY. Update the GitHub repo's main branch and create a new release.

.DESCRIPTION
ADMIN USE ONLY: this script updates the GitHub repo and needs to be run by an admin.
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

$changelogScriptPath = ".\Utils\Get-RscSdkLatestChangelog.ps1"
$changelogLatest = & $changelogScriptPath
if ( -Not $changelogLatest ) {
    throw "Failed to get the latest changelog entry."
}
$versionTag = $changelogLatest.latestVersionTag
$versionEntry = $changelogLatest.latestVersionEntry

Write-Host "Latest version tag: " -NoNewline
Write-Host $versionTag -ForegroundColor Cyan
Write-Host "Latest version entry:"
Write-Host $versionEntry -ForegroundColor Cyan

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
