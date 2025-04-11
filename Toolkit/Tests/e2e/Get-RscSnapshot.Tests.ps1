BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        sla = $null
    }
}


Describe -Name 'Get-RscSnapshot Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves Snapshots' -Test {
        $data.snapshots = Get-RscVmwareVm -Relic:$false -Replica:$false | Select-Object -first 1 | Get-RscSnapshot
        $data.snapshots | Should -Not -BeNullOrEmpty
    }

    It -Name 'retrieves Database Snapshots' -Test {
        $data.snapshots = Get-RscMssqlDatabase -Relic:$false -Replica:$false | Select-Object -first 1 | Get-RscSnapshot
        $data.snapshots | Should -Not -BeNullOrEmpty
    }

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
