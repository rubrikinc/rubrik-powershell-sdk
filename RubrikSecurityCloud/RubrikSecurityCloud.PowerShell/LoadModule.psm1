#
# Load Core DLL:
#
try {
    # Record the user's current working directory so that we can return to it when we 
    # are done loading the module
    $currentPath = Get-Location

    If ($PSVersionTable.PSEdition -eq "Desktop") {
        Write-Output("`nLoading Rubrik Security Cloud PowerShell Module (WindowsPowerShell)...`n")
        $moduleDir = Join-Path -Path $PSScriptRoot -ChildPath "net472"
    }
    else {
        Write-Output("`nLoading Rubrik Security Cloud PowerShell Module (PowerShell Core)...`n")
        $moduleDir = Join-Path -Path $PSScriptRoot -ChildPath "net6.0"
    }

    # To ensure that help files are loaded properly, we need to change directory to the 
    # desired platform build (i.e. net742 or net6.0)
    Set-Location -Path $moduleDir
    $modulePath = Join-Path -Path $moduleDir -ChildPath "RubrikSecurityCloud.PowerShell.dll"
    
    Write-Output "LoadModule.psm1: Import-Module $modulePath"
    Import-Module $modulePath -ErrorAction Stop

    Write-Output("Welcome to the Rubrik Security Cloud PowerShell SDK!`n")
    Write-Output("`tPlease refer to the Getting Started section of the Readme documentation: ")
    Write-Output("`thttps://github.com/rubrikinc/rubrik-powershell-sdk#getting-started`n")
}
catch {
    Write-Error("Unable to load Rubrik Security Cloud Module: " + $_)
}
finally {
    # Ensure the working directory has been set back to the original when the script exits
    Set-Location $currentPath
}