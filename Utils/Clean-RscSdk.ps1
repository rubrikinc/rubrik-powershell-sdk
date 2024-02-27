<#
.SYNOPSIS
    Clean up the Rubrik Security Cloud SDK build artifacts.
#>
param(
    [switch]$KeepOutputDir = $false
)
Set-Location $PSScriptRoot\.. 

if (-Not $KeepOutputDir) {
    if (Test-Path -Path .\Output) {
        Remove-Item -Recurse -Force .\Output
    }
    if (Test-Path -Path .\Output.Release) {
        Remove-Item -Recurse -Force .\Output.Release
    }
}
Get-ChildItem -Path . -Recurse -Directory | Where-Object {
    $_.Name -ieq "obj" -or $_.Name -ieq "bin"
} | Remove-Item -Force -Recurse
Get-ChildItem -Path . -Recurse | Where-Object { 
    $_.Name -ieq "testResults.xml" -or $_.Name -ieq "tmp_help"
} | Remove-Item -Force -Recurse
