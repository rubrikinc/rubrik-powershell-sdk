BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        objects = $null
    }
}

Describe -Name 'Get-RscOrganization Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves RSC Organizations' -Test {
        $data.objects = Get-RscOrganization 
        $data.objects | Should -Not -BeNullOrEmpty
    }

    Context -Name 'Object Count > 0' {
        BeforeEach {
            # Skip the tests if empty object list
            if ($data.objects.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 object is needed"
                return
            }
        }

        It -Name 'retrieves single org by RSC ID' -Test {
            $object0 = Get-RscOrganization -Id $data.objects[0].id
            $object0.name | Should -Be $data.objects[0].name
            $object0.id | Should -Be $data.objects[0].id
        }

        It -Name 'retrieves single org by name' -Test {
            $filteredObjects = Get-RscOrganization -Name $data.objects[0].FullName

            foreach ($obj in $filteredObjects) {
                $obj.name | Should -BeLike "*$($data.objects[0].name)*"
            }

            $ids = $filteredObjects | Where-Object { $_.id -eq $data.objects[0].id }
            ($ids.Count) | Should -BeExactly 1
        }
    }
}
