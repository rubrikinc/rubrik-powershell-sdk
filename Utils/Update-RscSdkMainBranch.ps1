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

# Checkout main branch
try {
    git checkout main
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
RunIfNotDry {
    git commit -am "$versionEntry"
}

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
