#Requires -Version 3
function Get-RscDiagnostics {
    <#
    .SYNOPSIS
    Run E2E diagnostics tests and produce a YAML report.

    .DESCRIPTION
    Runs all API-based E2E tests under Toolkit/Tests/e2e/ sequentially
    in the current process. Each test writes a per-API YAML file.
    After all tests complete, the per-API files are assembled into a
    combined report.yaml.

    .PARAMETER SkipTests
    Skip running tests; only assemble existing YAML files into report.yaml.

    .EXAMPLE
    Get-RscDiagnostics

    .EXAMPLE
    Get-RscDiagnostics -SkipTests
    #>
    [CmdletBinding()]
    param(
        [switch]$SkipTests
    )

    # ── Locate test files ──────────────────────────────────────────
    $e2eDir = $null
    $candidate = Join-Path $PSScriptRoot "..\Tests\e2e"
    if (Test-Path $candidate) {
        $e2eDir = (Resolve-Path $candidate).Path
    }
    if (-not $e2eDir) {
        $mod = Get-Module RubrikSecurityCloud
        if ($mod) {
            $candidate = Join-Path $mod.ModuleBase "Toolkit\Tests\e2e"
            if (Test-Path $candidate) { $e2eDir = (Resolve-Path $candidate).Path }
        }
    }
    if (-not $e2eDir) {
        Write-Error "Cannot find E2E test directory (Toolkit/Tests/e2e/)."
        return
    }

    $testFiles = Get-ChildItem -Path $e2eDir -Filter "*.Tests.ps1" | Sort-Object Name
    if ($testFiles.Count -eq 0) {
        Write-Error "No test files found in $e2eDir"
        return
    }
    $apis = @($testFiles | ForEach-Object { $_.BaseName -replace '\.Tests$', '' })

    # ── Diagnostics directory ──────────────────────────────────────
    $diagDir = Join-Path (Split-Path $PROFILE) "rubrik-powershell-sdk" "diagnostics"
    if (-not (Test-Path $diagDir)) {
        New-Item -ItemType Directory -Path $diagDir -Force | Out-Null
    }

    # ── Run tests ──────────────────────────────────────────────────
    $totalPassed = 0; $totalSkipped = 0; $totalFailed = 0

    if (-not $SkipTests) {
        # Source E2eTestInit (loads module + connects)
        $initScript = Join-Path (Split-Path $e2eDir) "E2eTestInit.ps1"
        if (Test-Path $initScript) { . $initScript }

        $isVerbose = $PSCmdlet.MyInvocation.BoundParameters['Verbose'] -eq $true
        $Global:E2eDiagVerbose = $isVerbose
        $pesterOutput = if ($isVerbose) { "Minimal" } else { "None" }

        foreach ($tf in $testFiles) {
            $api = $tf.BaseName -replace '\.Tests$', ''
            Write-Host "Running ${api}..." -NoNewline -ForegroundColor Cyan
            try {
                $result = Invoke-Pester -Path $tf.FullName -PassThru -Output $pesterOutput
                $p = $result.PassedCount; $s = $result.SkippedCount; $f = $result.FailedCount
                $totalPassed += $p; $totalSkipped += $s; $totalFailed += $f
                $color = if ($f -gt 0) { "Red" } elseif ($s -gt 0) { "Yellow" } else { "Green" }
                Write-Host "`r Running ${api}... " -NoNewline -ForegroundColor Cyan
                Write-Host "$p passed, $s skipped, $f failed" -ForegroundColor $color
            } catch {
                $totalFailed++
                Write-Host "`r Running ${api}... " -NoNewline -ForegroundColor Cyan
                Write-Host "ERROR: $_" -ForegroundColor Red
            }
        }
        Write-Host ""
        $color = if ($totalFailed -gt 0) { "Red" } elseif ($totalSkipped -gt 0) { "Yellow" } else { "Green" }
        Write-Host "Diagnostics complete: $totalPassed passed, $totalSkipped skipped, $totalFailed failed" -ForegroundColor $color
        Remove-Variable -Name E2eDiagVerbose -Scope Global -ErrorAction SilentlyContinue
    } else {
        Write-Host "Skipping tests, assembling report from existing YAML files." -ForegroundColor Yellow
    }

    # ── Assemble report.yaml ───────────────────────────────────────
    $sdkVer = try { (Get-Module RubrikSecurityCloud).Version.ToString() } catch { "unknown" }
    $schemaVer = try { [RubrikSecurityCloud.Types.SchemaMeta]::GraphqlSchemaVersion } catch { "unknown" }
    $deployVer = try {
        $v = (New-RscQuery -GqlQuery deploymentVersion).Invoke()
        if ($v) { "$v" } else { "unknown" }
    } catch { "unknown" }
    $deployName = try {
        $a = Get-RscAccount -ErrorAction SilentlyContinue
        if ($a -and $a.AccountId) { $a.AccountId } else { "unknown" }
    } catch { "unknown" }

    # Collect SDK DLL versions
    $mod = Get-Module RubrikSecurityCloud
    $dllVersions = @()
    if ($mod -and $mod.ModuleBase) {
        $tfm = if ($PSVersionTable.PSEdition -eq 'Desktop') { 'net481' } else { 'net6.0' }
        $dllDir = Join-Path $mod.ModuleBase $tfm
        if (Test-Path $dllDir) {
            foreach ($dll in (Get-ChildItem $dllDir -Filter 'RubrikSecurityCloud*.dll' | Sort-Object Name)) {
                $ver = try { [System.Diagnostics.FileVersionInfo]::GetVersionInfo($dll.FullName).FileVersion } catch { "?" }
                $dllVersions += "  - `"$($dll.Name) $ver`""
            }
        }
    }

    # Compute report totals from per-api YAML files (authoritative source)
    $reportPassed = 0; $reportSkipped = 0; $reportFailed = 0
    foreach ($api in $apis) {
        $yamlFile = Join-Path $diagDir "$api.diagnostics.yaml"
        if (Test-Path $yamlFile) {
            foreach ($line in (Get-Content $yamlFile)) {
                if     ($line -match '^\s+passed:\s*(\d+)')  { $reportPassed  += [int]$matches[1] }
                elseif ($line -match '^\s+skipped:\s*(\d+)') { $reportSkipped += [int]$matches[1] }
                elseif ($line -match '^\s+failed:\s*(\d+)')  { $reportFailed  += [int]$matches[1] }
            }
        }
    }
    $reportTotal = $reportPassed + $reportSkipped + $reportFailed

    # Build report header
    $reportLines = @(
        "# RSC Diagnostics Report"
        "sdk_version: `"$sdkVer`""
        "schema_version: `"$schemaVer`""
        "deploy_version: `"$deployVer`""
        "deploy_name: `"$deployName`""
        "generated: `"$([DateTimeOffset]::Now.ToString('o'))`""
        "dlls:"
    )
    $reportLines += $dllVersions
    $reportLines += @(
        "summary:"
        "  total: $reportTotal"
        "  passed: $reportPassed"
        "  skipped: $reportSkipped"
        "  failed: $reportFailed"
    )

    # Append per-api YAML
    foreach ($api in $apis) {
        $yamlFile = Join-Path $diagDir "$api.diagnostics.yaml"
        $reportLines += "---"
        if (Test-Path $yamlFile) {
            $reportLines += (Get-Content $yamlFile)
        } else {
            $reportLines += "api: $api"
            $reportLines += "timestamp: `"n/a`""
            $reportLines += "checks: []"
            $reportLines += "summary:"
            $reportLines += "  total: 0"
            $reportLines += "  passed: 0"
            $reportLines += "  skipped: 0"
            $reportLines += "  failed: 0"
        }
    }

    $reportPath = Join-Path $diagDir "report.yaml"
    Set-Content -Path $reportPath -Value ($reportLines -join "`n") -Encoding UTF8
    Write-Host "Report saved to: $reportPath" -ForegroundColor Green
}
