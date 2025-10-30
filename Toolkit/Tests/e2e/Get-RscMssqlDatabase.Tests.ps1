BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        objects = Get-RscMssqlDatabase
    }
}

Describe -Name 'Get-RscMssqlDatabase Tests' -Tag 'Public' -Fixture {

    Context -Name 'RscMssqlDatabase Count > 0' {
        BeforeEach {
            # Skip the tests if empty
            if ($data.objects.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 RscMssqlDatabase is needed"
                return
            }
        }

        It -Name 'retrieves single RscMssqlDatabase by RSC ID' -Test {
            $object0 = Get-RscMssqlDatabase -Id $data.objects[0].id
            $object0.name | Should -Be $data.objects[0].name
            $object0.id | Should -Be $data.objects[0].id
        }

        It -Name 'retrieves RscMssqlDatabases by name' -Test {
            $object0 = Get-RscMssqlDatabase -Name $data.objects[0].name
            $object0[0].name | Should -Be $data.objects[0].name
            $object0[0].id | Should -Be $data.objects[0].id
        }
    }
}

