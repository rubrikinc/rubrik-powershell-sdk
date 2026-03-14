# E2E Test Initialization
# Handles four scenarios:
#   1. Module already loaded (e.g. Get-RscDiagnostics pre-imported) -> skip
#   2. Dev mode: Utils/Import-RscModuleFromLocalOutputDir.ps1 exists -> use it
#   3. Output/installed dir: psd1 exists 2 levels up -> import from there
#   4. PSGallery: fallback to Import-Module RubrikSecurityCloud

if (-not (Get-Module RubrikSecurityCloud)) {
    $importScript = Join-Path $PSScriptRoot "..\..\Utils\Import-RscModuleFromLocalOutputDir.ps1"
    if (Test-Path $importScript) {
        . $importScript
    } else {
        # Try psd1 relative to test location (Output dir layout)
        $psd1 = Join-Path $PSScriptRoot "..\..\RubrikSecurityCloud.psd1"
        if (Test-Path $psd1) {
            Import-Module $psd1 -ErrorAction Stop
        } else {
            Import-Module RubrikSecurityCloud -ErrorAction Stop
        }
    }
}

. "$PSScriptRoot\E2eDiagnostics.ps1"

if (-not (Get-RscCluster -ErrorAction SilentlyContinue)) {
    Connect-Rsc
}
