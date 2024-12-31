BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        nasShares = $null
    }

    $Global:data = @{
        nasSystems = $null
    }
}

Describe -Name 'Get-RscNasShare Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves NAS-Shares' -Test {
        $data.nasShares = Get-RscNasShare
        $data.nasShares | Should -Not -BeNullOrEmpty

        $data.nasSystems = Get-RscNasSystem
        $data.nasSystems | Should -Not -BeNullOrEmpty
    }

    Context -Name 'NasShares Count > 0' {
        BeforeEach {
            # Skip the tests if empty NAS-Shares list 
            if ($data.nasShares.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 NAS-Share is needed"
                return
            }
        }

        It -Name 'retrieves single NAS-Share by Id' -Test {
            $nasShareById = Get-RscNasShare -Id $data.nasShares[0].id
            $nasShareById.name | Should -Be $data.nasShares[0].name
            $nasShareById.id | Should -Be $data.nasShares[0].id
        }

        It -Name 'retrieves single NAS-Share by Name' -Test {
            $nasSharesByName = Get-RscNasShare -Name $data.nasShares[0].name
            $nasSharesByName.Count | Should -BeGreaterThan 0
            # One of the NAS-Share in the list should have an id of $data.nasShares[0].id
            $match = $false
            foreach ($nasShare in $nasSharesByName) {
                if ($nasShare.id -eq $data.nasShares[0].id) {
                    $match = $true
                    break
                }
            }
            $match | Should -Be $true
        }

        It -Name 'retrieves NAS-Shares associated with the specified NAS-System' -Test {
            $nasSystemId = $data.nasSystems[0].id
            $nasSystemName = $data.nasSystems[0].name
            $nasSystemById = Get-RscNasSystem -Id $nasSystemId
            $nasSystemById.name | Should -Be $nasSystemName
            $nasSystemById.id | Should -Be $nasSystemId
        
            $nasSharesByNasSystemQuery = $nasSystemById | Get-RscNasShare -AsQuery
            $nasSharesByNasSystemQuery.Field.DescendantConnection.Nodes[0].NasSystem = New-Object -TypeName RubrikSecurityCloud.Types.NasSystem
            $nasSharesByNasSystemQuery.Field.DescendantConnection.Nodes[0].NasSystem.Id = "Fetch"
            $result = $nasSharesByNasSystemQuery.Invoke()
            $nasSharesByNasSystem = $result.DescendantConnection.Nodes
            foreach ($nasShare in $nasSharesByNasSystem) {
                # Skip the NAS-Share if it's invalid
                if ($null -eq $nasShare.Id) {
                    continue
                }
                $nasShare.NasSystem.Id | Should -Be $nasSystemId
            }
        }
    }

}