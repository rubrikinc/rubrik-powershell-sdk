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
} catch {
    throw "Failed to checkout 'main' branch."
}

# Merge devel into main without commit
try {
    git merge devel --no-commit --no-ff
} catch {
    throw "Failed to merge 'devel' into 'main'."
}

# Restore Output directory
try {
    git restore --source=HEAD --staged -- Output/
    git restore --source=HEAD -- Output/
} catch {
    throw "Failed to restore 'Output/' directory."
}

# Build the SDK
try {
    & .\Utils\Build-RscSdk.ps1
} catch {
    throw "Failed to build the SDK."
}

# Use regex to capture the latest version entry
$matches = [regex]::Match($changelogContent, "(## Version .+?)(?=\r?\n## Version |\z)", 'Singleline')
if ($matches.Success -and $matches.Groups.Count -gt 1) {
    $latestVersionEntry = $matches.Groups[1].Value
    # Commit changes with the latest version entry as the commit message
    try {
        git commit -am "$latestVersionEntry"
    } catch {
        throw "Failed to commit changes."
    }
} else {
    throw "Failed to find the latest version entry in CHANGELOG.md."
}

Write-Host "Build and release process completed successfully."