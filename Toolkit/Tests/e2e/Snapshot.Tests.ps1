BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Topic "Snapshot"
    $Global:data = @{ snapshots = $null }

    # Try VMware VMs first, then MSSQL databases
    $data.snapshots = Get-RscVmwareVm -Relic:$false -Replica:$false |
        Select-Object -First 1 |
        Get-RscSnapshot
    if (@($data.snapshots).Count -le 0) {
        $data.snapshots = Get-RscMssqlDatabase -Relic:$false -Replica:$false |
            Select-Object -First 1 |
            Get-RscSnapshot
    }
}

Describe -Name 'Snapshot' -Tag 'E2E' -Fixture {

    Context 'List Snapshots' {
        It 'finds snapshots from a workload' {
            if (@($data.snapshots).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List Snapshots" "skip" "No snapshots found"
                Set-ItResult -Skipped -Because "No snapshots found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List Snapshots" "pass" "Found $(@($data.snapshots).Count)"
        }
    }

    Context 'Retrieve by Id' {
        It 'retrieves snapshot by Id' {
            if (-not $data.snapshots -or @($data.snapshots).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve Snapshot by Id" "skip" "No snapshots"
                Set-ItResult -Skipped -Because "No snapshots"
                return
            }
            $snapshot = Get-RscSnapshot -Id $data.snapshots[0].id
            $snapshot.id | Should -Be $data.snapshots[0].id
            Add-E2eDiagnosticEntry $diag "Retrieve Snapshot by Id" "pass" "'$($snapshot.id)'"
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
