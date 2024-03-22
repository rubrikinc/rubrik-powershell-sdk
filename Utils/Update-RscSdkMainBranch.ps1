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
1. Check out the main branch;
2. Merge the devel branch into main without committing;
3. Build the SDK (unless -SkipBuild is given);
4. If a commit message is given, commit and push the changes to the main branch.

.PARAMETER CommitMessage
If not given, the script will not commit or push the changes to the main branch,
so it is effectively a dry run.

.EXAMPLE
.\Utils\Update-RscSdkMainBranch.ps1 -SkipBuild
#>
param(
    [switch]$SkipBuild = $false,
    [string]$CommitMessage = ""
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
    if ($LASTEXITCODE -ne 0) {
        throw
    }
}
catch {
    git reset --hard HEAD
    git checkout devel
    throw "Failed to merge 'devel' into 'main'."
}

# Build the SDK on the main branch
try {
    if (-not $SkipBuild) {
        .\Utils\Build-RscSdk.ps1 -Release
    }
}
catch {
    throw "Failed to build the SDK."
}


# Commit and push the changes to the main branch
if ($CommitMessage) {
    git commit -a -m "$CommitMessage"
    git push origin main
}

Write-Host "Done." -ForegroundColor Green
Write-Host "git status:"
git status
