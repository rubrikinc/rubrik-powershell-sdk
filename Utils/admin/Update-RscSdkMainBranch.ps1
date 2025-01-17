<#
.SYNOPSIS
ADMIN USE ONLY. Update the GitHub repo's main branch with the latest changes from the current branch.

.DESCRIPTION
ADMIN USE ONLY: this script updates the GitHub repo and needs to be run by an admin.
Running it as a non-admin will not alter the repository and
will only show what would have been done.

You can safely run: .\Utils\Update-RscSdkMainBranch.ps1 -SkipBuild
to see what would have been done without actually doing it.

This script will:
1. Check out the main branch;
2. Merge the current branch into main without committing;
3. Build the SDK (unless -SkipBuild is given);
4. If a commit message is given, commit and push the changes to the main branch.

.PARAMETER CommitMessage
If not given, the script will not commit or push the changes to the main branch,
so it is effectively a dry run.

.EXAMPLE
.\Utils\admin\Update-RscSdkMainBranch.ps1 -SkipBuild
#>
param(
    [switch]$SkipBuild = $false,
    [string]$CommitMessage = "",
    [switch]$StayOnMain = $false
)

# Change to the root of the repository
Set-Location $PSScriptRoot\..\..

# Check for a clean repo
$gitStatus = git status --porcelain
if ($gitStatus) {
    throw "Repository is not clean. Please commit or stash changes before running this script."
}

# Source branch (typically the devel branch)
$sourceBranch = git rev-parse --abbrev-ref HEAD

# Checkout main branch
try {
    git checkout main
}
catch {
    throw "Failed to checkout 'main' branch."
}

# Reset main to match $sourceBranch
try {
    git reset --hard $sourceBranch
    # This brings in new and modified files, but does not remove deleted files:
    # git checkout $sourceBranch -- .
    # This conflicts:
    # git merge $sourceBranch --no-commit --no-ff
    if ($LASTEXITCODE -ne 0) {
        throw
    }
}
catch {
    git reset --hard HEAD
    git checkout $sourceBranch
    throw "Failed to reset 'main' to '$sourceBranch'."
}

# Build the SDK on the main branch
try {
    if (-not $SkipBuild) {
        .\Utils\Build-RscSdk.ps1 -Release
    }
}
catch {
    git reset --hard HEAD
    git checkout $sourceBranch
    throw "Failed to build the SDK: $($_ | Out-String)"
}


# Push the changes only if a commit message is provided
if ($CommitMessage) {
    try {
        # Create a commit with the provided message
        git commit --allow-empty -a -m "$CommitMessage"

        # Push the changes to origin/main
        git push --force origin main
    }
    catch {
        git reset --hard HEAD
        git checkout $sourceBranch
        throw "Failed to push changes to 'main': $($_ | Out-String)"
    }
} else {
    Write-Host "No commit message provided. No changes have been pushed to 'main'." -ForegroundColor Yellow
}

# Return to the original branch if not staying on main
if ( -not $StayOnMain ) {
    git checkout $sourceBranch
}

Write-Host "Done." -ForegroundColor Green
Write-Host "git status:"
git status
