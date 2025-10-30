BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        snapshots = $null
    }

    # Try to get snapshots from VMware VMs first, then from MSSQL databases
    $Global:data.snapshots = Get-RscVmwareVm -Relic:$false -Replica:$false | Select-Object -first 1 | Get-RscSnapshot
    if ($Global:data.snapshots.Count -le 0) {
        $Global:data.snapshots = Get-RscMssqlDatabase -Relic:$false -Replica:$false | Select-Object -first 1 | Get-RscSnapshot
    }
}


Describe -Name 'Get-RscSnapshot Tests' -Tag 'Public' -Fixture {

    Context -Name 'Snapshot Count > 0' {
        BeforeEach {
            # Skip the tests if empty snapshot list
            if ($data.snapshots.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 snapshot is needed"
                return
            }
        }

        It -Name 'retrieves single Snapshot by Id' -Test {
            $snapshot = Get-RscSnapshot -Id $data.snapshots[0].id
            $snapshot.name | Should -Be $data.snapshots[0].name
            $snapshot.id | Should -Be $data.snapshots[0].id
        }
    }
}
