<#
.SYNOPSIS
    ADMIN USE ONLY. Test if the SDK is released correctly. (No-op if run as non-admin.)

.DESCRIPTION
    ADMIN USE ONLY. (No-op if run as non-admin.)
    This script tests if the SDK is released correctly.
    The latest published version on The PowerShell Gallery must match:
    - The SDK module version on the main branch.
    - The latest version tag in the CHANGELOG.md file on the main branch.
    - The latest release tag on the GitHub repository.

.OUTPUTS
    The published SDK version as a string (example: "1.9") if all
    checks pass successfully. Otherwise, an empty string is returned.
#>
[CmdletBinding()]
param()

# Change to the root of the repository
$originalCwd = $PWD
Set-Location $PSScriptRoot\..

# Stop on error
$ErrorActionPreference = "Stop"

# Uncomment this to enable Write-Debug output
# $DebugPreference = "Continue"

$SdkRoot = Join-Path -Path $PSScriptRoot -ChildPath '..\..' -Resolve

# Private function to retrieve information from the 'main' branch
function RetrieveMainBranchInfo {
    # Store the initial branch to always return to it
    $initialBranch = git rev-parse --abbrev-ref HEAD
    $mainSdkVersion = ""
    try {
        # Switch to the main branch
        if ( $initialBranch -ne "main" ) {
            git checkout main | Out-Null
            if ($LASTEXITCODE -ne 0) {
                Write-Host "Error: Failed to switch to the 'main' branch." -ForegroundColor Red
                throw "Failed to switch to main branch"
            }
        }
        git pull --rebase | Out-Null
        if ($LASTEXITCODE -ne 0) {
            Write-Host "Error: Failed to pull and rebase on the 'main' branch." -ForegroundColor Red
            throw "Failed to pull and rebase"
        }

        # Get the SDK version on the main branch
        $mainSdkVersion = ( & "$SdkRoot\Utils\Get-RscSdkVersion.ps1")
        Write-Host "SDK Version on main branch: $mainSdkVersion" -ForegroundColor Blue
        
        # Get the latest changelog version
        $mainChangelogLatestVersionTag = (& "$PSScriptRoot\Get-RscSdkLatestChangelog.ps1").latestVersionTag
        Write-Host "Latest version tag from changelog on main branch: $mainChangelogLatestVersionTag" -ForegroundColor Blue
           
                
        # Ensure the changelog version matches the SDK version
        $expectedTag = "Version_$mainSdkVersion"
        if ($mainChangelogLatestVersionTag -ne $expectedTag) {
            Write-Host "Error: Changelog version tag mismatch on main branch." -ForegroundColor Red
            Write-Host "Expected: $expectedTag, Found: $mainChangelogLatestVersionTag" -ForegroundColor Red
            throw "Changelog version mismatch on main branch"
        }
    }
    finally {
        # Switch back to the devel branch, regardless of success or failure
        $currentBranch = git rev-parse --abbrev-ref HEAD
        if ($currentBranch -ne $initialBranch) {
            Write-Host "Switching back to the ' $initialBranch' branch..."
            git checkout $initialBranch | Out-Null
            if ($LASTEXITCODE -ne 0) {
                Write-Host "Error: Failed to switch back to the ' $initialBranch' branch." -ForegroundColor Red
            }
        }
    }
    return $mainSdkVersion
}

function Test-RscSdkRelease {
    try {
        $statusOutput = git status --porcelain
        if ($statusOutput) {
            Write-Host "Error: Your working directory has pending changes." -ForegroundColor Red
            Write-Host "Please commit, stash, or discard changes before proceeding." -ForegroundColor Red
            throw "Pending changes in working directory"
        }

        # Get the latest released version from the PowerShell Gallery
        Write-Host "Checking latest release from the PowerShell Gallery..."
        $moduleInfo = Find-Module -Name RubrikSecurityCloud -Repository PSGallery
        if ($moduleInfo) {
            $latestGalleryRelease = $moduleInfo.Version
            Write-Host "Latest release version from the PowerShell Gallery: $latestGalleryRelease" -ForegroundColor Blue
        }
        else {
            Write-Host "Error: Failed to fetch the latest release from the PowerShell Gallery." -ForegroundColor Red
            throw "PowerShell Gallery release fetch failed"
        }

        # Get the latest released version from GitHub
        Write-Host "Checking latest release from GitHub repository..."
        $latestGitHubRelease = gh release view --json tagName --jq '.tagName'
        if ($LASTEXITCODE -ne 0) {
            Write-Host "Error: Failed to fetch the latest release from GitHub." -ForegroundColor Red
            throw "GitHub release fetch failed"
        }
        Write-Host "Latest release version from GitHub: $latestGitHubRelease" -ForegroundColor Blue
        
        # Get the SDK version on the main branch
        $mainSdkVersion = RetrieveMainBranchInfo

        # Ensure the GitHub latest release matches the main branch SDK version
        if ($latestGitHubRelease -ne "Version_$mainSdkVersion") {
            Write-Host "Error: Latest GitHub release version does not match the main branch's SDK version." -ForegroundColor Red
            Write-Host "Expected: Version_$mainSdkVersion, Found: $latestGitHubRelease" -ForegroundColor Red
            throw "GitHub release version mismatch"
        }
        
        # Ensure the PowerShell Gallery latest release matches the main branch SDK version
        if ($latestGalleryRelease -ne $mainSdkVersion) {
            Write-Host "Error: Latest PowerShell Gallery release version does not match the main branch's SDK version." -ForegroundColor Red
            Write-Host "Expected: $mainSdkVersion, Found: $latestGalleryRelease" -ForegroundColor Red
            throw "PowerShell Gallery release version mismatch"
        }

    }
    catch {
        Write-Host "An error occurred: $_" -ForegroundColor Red
        return ""
    }
    Write-Host "All checks passed successfully." -ForegroundColor Green
    return $mainSdkVersion
}

# Call the function
Test-RscSdkRelease

# Return to the original directory
Set-Location $originalCwd
