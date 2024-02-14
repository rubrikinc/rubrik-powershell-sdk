Set-Location $PSScriptRoot\.. 

if (Test-Path -Path .\Output) {
    Remove-Item -Recurse -Force .\Output
}
if (Test-Path -Path .\Output.Release) {
    Remove-Item -Recurse -Force .\Output.Release
}
Get-ChildItem -Path . -Filter "obj" -Recurse -Directory | Remove-Item -Force -Recurse
Get-ChildItem -Path . -Filter "bin" -Recurse -Directory | Remove-Item -Force -Recurse
Get-ChildItem -Path . -Recurse | Where-Object { $_.Name -ieq "testResults.xml" -or $_.Name -ieq "tmp_help" } | Remove-Item -Force -Recurse
