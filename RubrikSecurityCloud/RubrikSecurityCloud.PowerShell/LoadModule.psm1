#
# Load Core DLL:
#

try {
    If ($PSVersionTable.PSEdition -eq "Desktop") {
        Write-Output("`nLoading Rubrik Security Cloud PowerShell Module (WindowsPowerShell)...`n")
        $modulePath = Join-Path -Path (Join-Path -Path $PSScriptRoot -ChildPath "net472") -ChildPath "RubrikSecurityCloud.PowerShell.dll"
    }
    else {
        Write-Output("`nLoading Rubrik Security Cloud PowerShell Module (PowerShell Core)...`n")
        $modulePath = Join-Path -Path (Join-Path -Path $PSScriptRoot -ChildPath "net6.0") -ChildPath "RubrikSecurityCloud.PowerShell.dll"
    }

    Write-Output "LoadModule.psm1: Import-Module $modulePath"
    Import-Module $modulePath -ErrorAction Stop

    Write-Output("Welcome to the Rubrik Security Cloud PowerShell SDK!`n")
    Write-Output("`tPlease refer to the Getting Started section of the Readme documentation: ")
    Write-Output("`thttps://github.com/rubrikinc/rubrik-powershell-sdk#getting-started`n")
}
catch {
    Write-Error("Unable to load Rubrik Security Cloud Module: " + $_)
}
