#
# Load Core DLL:
#

try {
    If ($PSVersionTable.PSEdition -eq "Desktop") {
        Write-Output("`nLoading Rubrik Security Cloud PowerShell Module (WindowsPowerShell)...`n")
        $moduleDir = Join-Path -Path $PSScriptRoot -ChildPath "net472"
    }
    else {
        Write-Output("`nLoading Rubrik Security Cloud PowerShell Module (PowerShell Core)...`n")
        $moduleDir = Join-Path -Path $PSScriptRoot -ChildPath "net6.0"
    }

    Write-Output "LoadModule.psm1: Import-Module $modulePath"
    Set-Location -Path $moduleDir
    $modulePath = Join-Path -Path $moduleDir -ChildPath "RubrikSecurityCloud.PowerShell.Dll"
    Import-Module $modulePath -ErrorAction Stop

    Write-Output("Welcome to the Rubrik Security Cloud PowerShell SDK!`n")
    Write-Output("`tPlease refer to the Getting Started section of the Readme documentation: ")
    Write-Output("`thttps://github.com/rubrikinc/rubrik-powershell-sdk#getting-started`n")
}
catch {
    Write-Error("Unable to load Rubrik Security Cloud Module: " + $_)
}
