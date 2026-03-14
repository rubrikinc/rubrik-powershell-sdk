<#
.SYNOPSIS
Diagnostics YAML output and SLA safety helpers for E2E tests.

.DESCRIPTION
Provides functions to:
- Record pass/skip/fail diagnostics for each E2E test check
- Write diagnostics to a YAML file under the SDK config directory
- Safely create/cleanup test SLA domains with an unmistakable name prefix
#>

# --- SLA Safety Helpers ---

$script:E2E_SLA_PREFIX = "_SDK_E2E_TEST_DO_NOT_USE_"

function Remove-E2eTestSlas {
    <#
    .SYNOPSIS
    Delete any SLA domains whose name starts with the E2E test prefix.
    Returns the number of SLAs deleted.
    #>
    $testSlas = Get-RscSla | Where-Object { $_.name -like "$($script:E2E_SLA_PREFIX)*" }
    foreach ($sla in $testSlas) {
        $q = New-RscMutationSla -Operation DeleteGlobal
        $q.Var.id = $sla.id
        $q | Invoke-Rsc | Out-Null
    }
    return @($testSlas).Count
}

function New-E2eTestSlaName {
    <#
    .SYNOPSIS
    Generate a unique SLA name with the E2E test prefix.
    #>
    return "$($script:E2E_SLA_PREFIX)$(New-Guid)"
}

# --- Diagnostics YAML ---

function New-E2eDiagnostics {
    <#
    .SYNOPSIS
    Create a new diagnostics object for an API area.
    #>
    param(
        [Parameter(Mandatory)]
        [string]$Api
    )
    @{
        Api    = $Api
        Checks = [System.Collections.ArrayList]::new()
    }
}

function Add-E2eDiagnosticEntry {
    <#
    .SYNOPSIS
    Record a check result (pass, skip, or fail) in the diagnostics object.
    #>
    param(
        [Parameter(Mandatory)]
        $Diag,
        [Parameter(Mandatory)]
        [string]$Name,
        [Parameter(Mandatory)]
        [ValidateSet("pass", "skip", "fail")]
        [string]$Status,
        [string]$Detail = ""
    )
    $Diag.Checks.Add(@{ Name = $Name; Status = $Status; Detail = $Detail }) | Out-Null
}

function Save-E2eDiagnostics {
    <#
    .SYNOPSIS
    Write the diagnostics object to a YAML file under the SDK config directory.
    Output path: ~/.config/powershell/rubrik-powershell-sdk/diagnostics/<Api>.diagnostics.yaml
    #>
    param(
        [Parameter(Mandatory)]
        $Diag
    )
    $configDir = Join-Path (Split-Path $PROFILE) "rubrik-powershell-sdk" "diagnostics"
    if (-not (Test-Path $configDir)) {
        New-Item -ItemType Directory -Path $configDir -Force | Out-Null
    }
    $path = Join-Path $configDir "$($Diag.Api).diagnostics.yaml"

    # Capture environment info
    $sdkVersion = try { (Get-Module RubrikSecurityCloud).Version.ToString() } catch { "unknown" }
    $deployVersion = try {
        $v = (New-RscQuery -GqlQuery deploymentVersion).Invoke()
        if ($v) { $v } else { "unknown" }
    } catch { "unknown" }
    $deployName = try {
        $a = Get-RscAccount -ErrorAction SilentlyContinue
        if ($a -and $a.AccountId) { $a.AccountId } else { "unknown" }
    } catch { "unknown" }

    $schemaVersion = try { [RubrikSecurityCloud.Types.SchemaMeta]::GraphqlSchemaVersion } catch { "unknown" }

    $yaml = "api: $($Diag.Api)`n"
    $yaml += "timestamp: `"$(Get-Date -Format 'o')`"`n"
    $yaml += "sdk_version: `"$sdkVersion`"`n"
    $yaml += "schema_version: `"$schemaVersion`"`n"
    $yaml += "deploy_version: `"$deployVersion`"`n"
    $yaml += "deploy_name: `"$deployName`"`n"
    $yaml += "checks:`n"
    $passed = 0; $skipped = 0; $failed = 0
    foreach ($c in $Diag.Checks) {
        $yaml += "  - name: `"$($c.Name)`"`n"
        $yaml += "    status: $($c.Status)`n"
        $yaml += "    detail: `"$($c.Detail)`"`n"
        switch ($c.Status) {
            "pass" { $passed++ }
            "skip" { $skipped++ }
            "fail" { $failed++ }
        }
    }
    $total = $Diag.Checks.Count
    $yaml += "summary:`n"
    $yaml += "  total: $total`n"
    $yaml += "  passed: $passed`n"
    $yaml += "  skipped: $skipped`n"
    $yaml += "  failed: $failed`n"
    Set-Content -Path $path -Value $yaml -Encoding UTF8
}
