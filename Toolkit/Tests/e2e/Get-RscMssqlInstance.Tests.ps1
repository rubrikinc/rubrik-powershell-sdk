BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        objects = $null
    }
}

Describe -Name 'Get-RscMssqlInstance Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves RscMssqlInstances' -Test {
        $data.objects = Get-RscMssqlInstance
        $data.objects | Should -Not -BeNullOrEmpty
    }

    Context -Name 'RscMssqlInstance Count > 0' {
        BeforeEach {
            # Skip the tests if empty 
            if ($data.objects.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 RscMssqlInstance is needed"
                return
            }
        }

        It -Name 'retrieves single RscMssqlInstance by RSC ID' -Test {
            $object0 = Get-RscMssqlInstance -Id $data.objects[0].PhysicalChildConnection.Nodes[0].id
            $object0.name | Should -Be $data.objects[0].PhysicalChildConnection.Nodes[0].name
            $object0.id | Should -Be $data.objects[0].PhysicalChildConnection.Nodes[0].id
        }

        # Can't get an instance by name without specifying a host. Not good for automated e2e tests.
        # It -Name 'retrieves RscMssqlInstance by name' -Test {
        #     $object0 = Get-RscMssqlInstance -Name $data.objects[0].PhysicalChildConnection.Nodes[0].name
        #     $object0[0].name | Should -Be $data.objects[0].PhysicalChildConnection.Nodes[0].name
        #     $object0[0].id | Should -Be $data.objects[0].PhysicalChildConnection.Nodes[0].id
        # }
    }
}

