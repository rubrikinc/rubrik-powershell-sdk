$ModuleName = 'RubrikSecurityCloud'
$DllName = $ModuleName + '.psd1'
$DllDir = '../Output/'
$DllPath = Join-Path $PSScriptRoot $DllDir $DllName

Remove-Module -Name $ModuleName -ErrorAction 'SilentlyContinue'
Import-Module $DllPath -Verbose
Connect-Rsc
