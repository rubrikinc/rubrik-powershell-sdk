$psdFile = "$PSScriptRoot/RubrikSecurityCloud.psd1"
$psdContent = Get-Content -Path $psdFile -Raw

$toolkitDir = Join-Path (Get-Item $PSScriptRoot).Parent.Parent.FullName "Toolkit"
$typesToProcess = (Get-ChildItem -Path "$toolkitDir/Format" -Filter "*.ps1xml").Name -replace "^","`n  `"Toolkit/Format/" -replace "$","`"" -join ','
$psdContent = $psdContent -Replace '(?s)(TypesToProcess\s*=\s*)@\([^\)]*\)', "`$1@($typesToProcess)"


Set-Content -Path $psdFile -Value $psdContent.Trim()
