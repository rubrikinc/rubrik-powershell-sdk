$psdFile = "$PSScriptRoot/RubrikSecurityCloud.psd1"
$psdContent = Get-Content -Path $psdFile -Raw

$toolkitDir = Join-Path (Get-Item $PSScriptRoot).Parent.Parent.FullName "Toolkit"

# Update list of ps1xml files to process:
$ps1xmlFiles = Get-ChildItem -Path "$toolkitDir/Format" -Filter "*.ps1xml"
$typesToProcess = ""
if ($ps1xmlFiles.Count -gt 0) {
    $typesToProcess = $ps1xmlFiles.Name -replace "^","`n  `"Toolkit/Format/" -replace "$","`"" -join ','
}
$psdContent = $psdContent -Replace '(?s)(TypesToProcess\s*=\s*)@\([^\)]*\)', "`$1@($typesToProcess)"

# Update RubrikSecurityCloud.psd1:
Set-Content -Path $psdFile -Value $psdContent.Trim()
