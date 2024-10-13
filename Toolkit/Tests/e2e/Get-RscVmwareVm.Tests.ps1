BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        vm = $null
    }
}

Describe -Name 'Get-RscVmwareVm Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves VMs' -Test {
        $data.vm = Get-RscVmwareVm
        # Write-Host "data.vm.count = $($data.vm.count)"
        $data.vm | Should -Not -BeNullOrEmpty
    }

    Context -Name 'VM Count > 0' {
        BeforeEach {
            # Skip the tests if empty VM list
            if ($data.vm.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 VM is needed"
                return
            }
        }

        It -Name 'retrieves single VM' -Test {
            $vm0 = Get-RscVmwareVm -Id $data.vm[0].id
            $vm0.name | Should -Be $data.vm[0].name
            $vm0.id | Should -Be $data.vm[0].id
        }

        It -Name 'retrieves single VM by Name' -Test {
            $vmWithName = Get-RscVmwareVm -Name $data.vm[0].name
            $vmWithName.Count | Should -BeGreaterThan 0
            # One of the VMs in the list should have an id of $data.vm[0].id
            $match = $false
            foreach ($vm in $vmWithName) {
                if ($vm.id -eq $data.vm[0].id) {
                    $match = $true
                    break
                }
            }
            $match | Should -Be $true
        }
    }
}
