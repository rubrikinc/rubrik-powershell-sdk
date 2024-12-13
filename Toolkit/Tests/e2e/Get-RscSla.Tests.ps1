BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        sla = $null
    }
}

# TODO: Fix this test: replace -Skip with -Fixture
# see https://rubrik.atlassian.net/browse/SPARK-462875
Describe -Name 'Get-RscSla Tests' -Tag 'Public' -Skip {

    It -Name 'retrieves SLAs' -Test {
        $data.sla = Get-RscSla
        # Write-Host "data.sla.count = $($data.sla.count)"
        $data.sla | Should -Not -BeNullOrEmpty
    }

    Context -Name 'SLA Count > 0' {
        BeforeEach {
            # Skip the tests if empty SLA list
            if ($data.sla.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 SLA is needed"
                return
            }
        }

        It -Name 'retrieves single SLA by Id' -Test {
            $sla0 = Get-RscSla -Id $data.sla[0].id
            $sla0.name | Should -Be $data.sla[0].name
            $sla0.id | Should -Be $data.sla[0].id
        }

        It -Name 'retrieves single SLA by Name' -Test {
            $slaWithName = Get-RscSla -Name $data.sla[0].name
            $slaWithName.Count | Should -BeGreaterThan 0
            # One of the SLAs in the list should have an id of $data.sla[0].id
            $match = $false
            foreach ($sla in $slaWithName) {
                if ($sla.id -eq $data.sla[0].id) {
                    $match = $true
                    break
                }
            }
            $match | Should -Be $true
        }
    }

}
