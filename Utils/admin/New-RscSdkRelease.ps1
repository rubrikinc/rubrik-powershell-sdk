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
.\Utils\admin\New-RscSdkRelease.ps1
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

$SdkRoot = Join-Path -Path $PSScriptRoot -ChildPath '..\..' -Resolve

$candidate = & "$SdkRoot\Utils\admin\Test-RscSdkCandidate.ps1"
if (-Not $candidate) {
    throw "Could not gather info about current branch."
}
$versionEntry = $candidate.VersionEntry
$versionTag = $candidate.VersionTag

# Change to the root of the repository
Set-Location $SdkRoot

$sourceBranch = git rev-parse --abbrev-ref HEAD

# Update main branch
$CommitMessage = ""
RunIfNotDry {
    $script:CommitMessage = $versionEntry
}

# Passing an empty CommitMessage makes it a dry run
.\Utils\admin\Update-RscSdkMainBranch.ps1 -CommitMessage "$CommitMessage" -StayOnMain

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

git checkout $sourceBranch

# Prepare devel branch for further development
RunIfNotDry {
    if ($sourceBranch -eq 'devel') {
        Set-Location $PSScriptRoot\..\..
        .\Utils\admin\New-RscSdkChangeLogEntry.ps1 -Commit
        git push origin devel
    }
}

Write-Host "Done." -ForegroundColor Green
Write-Host "git status:"
git status
