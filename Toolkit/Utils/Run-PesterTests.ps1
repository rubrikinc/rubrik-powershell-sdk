
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

function InstallOrUpdatePesterIfNeeded {
    $minimumVersion = [Version]"5.0.0"
    # Check if Pester is installed and get the version
    $pesterInstalled = Get-Module -ListAvailable -Name Pester | Sort-Object Version -Descending | Select-Object -First 1

    if ($pesterInstalled -and ($pesterInstalled.Version -lt $minimumVersion)) {
        Write-Output "Pester is installed but the version ($($pesterInstalled.Version)) is lower than the minimum required version ($minimumVersion). Upgrading Pester..."
        # Upgrade Pester to the latest version
        Install-Module -Name Pester -Force -AllowClobber -Scope CurrentUser
        Import-Module -Name Pester -Force
    }
    elseif (-not $pesterInstalled) {
        Write-Output "Pester is not installed. Installing the latest version..."

        # Ensure the user has the necessary permissions
        # and is running the script as an administrator
        if (-not ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)) {
            Write-Error "You need to run this script as an Administrator to install modules (PowerShellGet and Pester)"
            return
        }

        # Update the PowerShellGet module first to avoid issues
        Install-Module -Name PowerShellGet -Force -AllowClobber -Scope CurrentUser

        # Now install Pester
        Install-Module -Name Pester -Force -RequiredVersion $minimumVersion -AllowClobber -Scope CurrentUser
    } else {
        Write-Verbose "Pester is already installed with a compatible version ($($pesterInstalled.Version))."
    }
}

# Call the function to ensure Pester is installed and >= 5.0.0
InstallOrUpdatePesterIfNeeded

$p = Get-Item -Path $TestPath
$displayPath = Join-Path $p.Parent.Parent.Name $p.Parent.Name $p.Name
Write-Host "`n[$($p.Name)] Running Pester tests in $displayPath" -ForegroundColor Cyan

Invoke-Pester -CI $TestPath
