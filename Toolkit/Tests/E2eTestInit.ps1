# E2E Test Initialization
# Handles three scenarios:
#   1. Dev mode: module not loaded -> import from Output/
#   2. PSGallery install (Get-RscDiagnostics): module already loaded -> skip import
#   3. PSGallery install, no Utils/: fallback to Import-Module

if (-not (Get-Module RubrikSecurityCloud)) {
    $importScript = Join-Path $PSScriptRoot "..\..\Utils\Import-RscModuleFromLocalOutputDir.ps1"
    if (Test-Path $importScript) {
        . $importScript
    } else {
        Import-Module RubrikSecurityCloud -ErrorAction Stop
    }
}

. "$PSScriptRoot\E2eDiagnostics.ps1"

if (-not (Get-RscCluster -ErrorAction SilentlyContinue)) {
    Connect-Rsc
}
