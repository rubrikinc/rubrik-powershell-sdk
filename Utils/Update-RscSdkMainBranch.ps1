<#
.SYNOPSIS
ADMIN USE ONLY. Update the GitHub repo's main branch with the latest changes from the devel branch.

.DESCRIPTION
ADMIN USE ONLY: this script updates the GitHub repo and needs to be run by an admin.
Running it as a non-admin will not alter the repository and
will only show what would have been done.

You can safely run: .\Utils\Update-RscSdkMainBranch.ps1 -SkipBuild
to see what would have been done without actually doing it.

This script will:
1. Check out the main branch
2. Merge the devel branch into main without committing
3. Restore the Output directory
4. Build the SDK and populate the Output directory (unless -SkipBuild is given)
5. Get the latest changelog entry
6. Commit the changes with the latest version entry as the commit message
7. Push the changes to the main branch
8. Create a new GitHub release

.EXAMPLE
.\Utils\Update-RscSdkMainBranch.ps1 -SkipBuild
#>
param(
    [switch]$SkipBuild = $false,
    [switch]$NotDry = $false
)

# Change to the root of the repository
Set-Location $PSScriptRoot\..

# Check for a clean repo
$gitStatus = git status --porcelain
if ($gitStatus) {
    throw "Repository is not clean. Please commit or stash changes before running this script."
}

# Update devel branch
try {
    git checkout devel
    git pull --rebase origin devel
}
catch {
    throw "Failed to checkout 'devel' branch."
}

# Checkout main branch
try {
    git checkout main
    git pull --rebase origin main
}
catch {
    throw "Failed to checkout 'main' branch."
}

# Merge devel into main without commit
try {
    git merge devel --no-commit --no-ff
}
catch {
    throw "Failed to merge 'devel' into 'main'."
}

# Restore Output directory
try {
    git restore --source=HEAD --staged -- Output/
    git restore --source=HEAD -- Output/
}
catch {
    throw "Failed to restore 'Output/' directory."
}

# Build the SDK
try {
    if (-not $SkipBuild) {
        .\Utils\Build-RscSdk.ps1
    }
}
catch {
    throw "Failed to build the SDK."
}

$changelogScriptPath = Join-Path -Path $PSScriptRoot -ChildPath "Get-RscSdkLatestChangelog.ps1"
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

function RunIfNotDry {
    param(
        [ScriptBlock]$CodeBlock
    )

    # Check if the global variable $NotDry is set and not false
    if ($global:NotDry) {
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

# Commit changes with the latest version entry as the commit message
git add -f Output/
git commit -a -m "$versionEntry"

# Push the changes to the main branch
RunIfNotDry {
    git push origin main
}

# Create a new GitHub release
RunIfNotDry {
    gh release create $versionTag -t $versionTag -n "$versionEntry"
}

Write-Host "Done." -ForegroundColor Green
Write-Host "git status:"
git status
