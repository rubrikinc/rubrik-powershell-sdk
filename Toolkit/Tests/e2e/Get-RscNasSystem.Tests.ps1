BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        nasSystems = $null
    }
}

Describe -Name 'Get-RscNasSystem Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves NAS-Systems' -Test {
        $data.nasSystems = Get-RscNasSystem
        Write-Host "data.nasSystems.count = $($data.nasSystems.count)"
        $data.nasSystems | Should -Not -BeNullOrEmpty
    }

    Context -Name 'NasSystems Count > 0' {
        BeforeEach {
            # Skip the tests if empty NAS-Systems list 
            if ($data.nasSystems.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 NAS-System is needed"
                return
            }
        }

        It -Name 'retrieves single NAS-System by Id' -Test {
            $nasSystem0 = Get-RscNasSystem -Id $data.nasSystems[0].id
            $nasSystem0.name | Should -Be $data.nasSystems[0].name
            $nasSystem0.id | Should -Be $data.nasSystems[0].id
        }

        It -Name 'retrieves single NAS-System by Name' -Test {
            $nasSystemsWithGivenName = Get-RscNasSystem -Name $data.nasSystems[0].name
            $nasSystemsWithGivenName.Count | Should -BeGreaterThan 0
            # One of the NAS-Systems in the list should have an id of $data.nasSystems[0].id
            $match = $false
            foreach ($nasSystem in $nasSystemsWithGivenName) {
                if ($nasSystem.id -eq $data.nasSystems[0].id) {
                    $match = $true
                    break
                }
            }
            $match | Should -Be $true
        }
    }

}
