
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

function InstallPesterIfNeeded {
    # Check if Pester is installed
    $pesterInstalled = Get-Module -ListAvailable -Name Pester

    if (-not $pesterInstalled) {
        # Ensure the user has the necessary permissions
        # and is running the script as an administrator
        if (-not ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)) {
            Write-Error "You need to run this script as an Administrator to install modules (PowerShellGet and Pester)"
            return
        }
    
        # Update the PowerShellGet module first to avoid issues
        Install-Module -Name PowerShellGet -Force -AllowClobber -Scope CurrentUser
    
        # Now install Pester
        Install-Module -Name Pester -Force -Scope CurrentUser
    } 
}


InstallPesterIfNeeded
$p = Get-Item -Path $TestPath
$displayPath = Join-Path $p.Parent.Parent.Name $p.Parent.Name $p.Name
Write-Host "`n[$($p.Name)] Running Pester tests in $displayPath" -ForegroundColor Cyan

Invoke-Pester -CI $TestPath
