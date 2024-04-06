<#
.SYNOPSIS
Run Pester tests in a given directory.
#>
[CmdletBinding()] # Enable common parameters like -Verbose
Param(
    [Parameter(Mandatory = $true, Position = 0)]
    [ValidateScript({
            if ([System.IO.Path]::IsPathRooted($_)) {
                return Test-Path $_ -PathType Container
            }
            else {
                $absolutePath = Join-Path -Path $PWD -ChildPath $_
                return Test-Path $absolutePath -PathType Container
            }
        })]
    [string]$TestPath
)

# Normalize the TestPath
if (-not [System.IO.Path]::IsPathRooted($TestPath)) {
    $TestPath = Join-Path -Path $PWD -ChildPath $TestPath
}
# Resolve "." and ".." in the path
$TestPath = (Get-Item -Path $TestPath).FullName

<#
.SYNOPSIS
Installs or updates the Pester module to a minimum required version.

.DESCRIPTION
On PowerShell 7, this function installs or updates the Pester module to 5.3.3 or later.
On PowerShell 5.1, the pre-installed Pester module (version 3.4.0) is signed by Microsoft
and updating to a newer version of Pester can result in a digital signature conflict.
This is because the newer version of Pester might not be signed by Microsoft.
To address this issue, this function bypasses publisher signature check on PowerShell 5.1.

.NOTES
It's important to use the `-SkipPublisherCheck` option cautiously,
as bypassing publisher checks can introduce security risks.
This function uses it conditionally, only for PowerShell 5.1.
For environments running newer versions of PowerShell,
this function does not bypass publisher checks.
#>
function InstallOrUpdatePesterIfNeeded {
    $minPesterVersion = [Version]"5.3.3"
    $psVersion = $PSVersionTable.PSVersion
    $installParams = @{
        Name = 'Pester';
        Force = $true;
        AllowClobber = $true;
        Scope = 'CurrentUser';
        SkipPublisherCheck = $psVersion.Major -eq 5 -and $psVersion.Minor -eq 1;
    }
    $doInstall = $false
    
    # Check if Pester is installed and get the version
    $pesterInstalled = Get-Module -ListAvailable -Name Pester | Sort-Object Version -Descending | Select-Object -First 1

    if ($pesterInstalled -and ($pesterInstalled.Version -lt $minPesterVersion)) {
        Write-Host "Pester is installed but the version ($($pesterInstalled.Version)) is lower than the minimum required version ($minPesterVersion). Upgrading Pester..."
        $doInstall = $true
    }
    elseif (-not $pesterInstalled) {
        Write-Host "Pester is not installed. Installing the latest version..."
        $doInstall = $true
    }
    else {
        Write-Verbose "Pester is already installed with a compatible version ($($pesterInstalled.Version))."
    }

    if ($doInstall) {
        # Ensure the user has the necessary permissions
        # and is running the script as an administrator
        # if (-not ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)) {
        #     Write-Error "You need to run this script as an Administrator to install modules (PowerShellGet and Pester)"
        #     return
        # }
    
        # Update the PowerShellGet module first to avoid issues
        Install-Module -Name PowerShellGet -Force -AllowClobber -Scope CurrentUser

        # Upgrade Pester to the latest version
        Install-Module @installParams
        # Re-import the Pester module to ensure the updated version is used
        Import-Module -Name Pester -Force
    }
    else {
        Import-Module -Name Pester -Version $pesterInstalled.Version -Force
    }
}

# Call the function to ensure Pester is installed and >= 5.0.0
InstallOrUpdatePesterIfNeeded

$p = Get-Item -Path $TestPath
if ($PSVersionTable.PSVersion.Major -eq 5) {
    $displayPath = $p.FullName
} else {
    $displayPath = Join-Path $p.Parent.Parent.Name $p.Parent.Name $p.Name
}
Write-Host "`n[$($p.Name)] Running Pester tests in $displayPath" -ForegroundColor Cyan

# Run Pester tests and pass through the results
$testResults = Invoke-Pester -CI $TestPath -PassThru
$testResults

