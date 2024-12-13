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

# TODO: Fix this test: replace -Skip with -Fixture
# see https://rubrik.atlassian.net/browse/SPARK-462873
Write-Warning "TODO: Get-RscNasShare Tests are skipped"
Describe -Name 'Get-RscNasShare Tests' -Tag 'Public' -Skip {

    It -Name 'retrieves NAS-Shares' -Test {
        $data.nasShares = Get-RscNasShare
        Write-Host "NasShares Count = $($data.nasShares.count)"
        $data.nasShares | Should -Not -BeNullOrEmpty

        $data.nasSystems = Get-RscNasSystem
        Write-Host "NasSystems Count = $($data.nasSystems.count)"
        $data.nasSystems | Should -Not -BeNullOrEmpty
    }

    Context -Name 'NasShares Count > 0' {
        BeforeEach {
            # Skip the tests if empty NAS-Systems list 
            if ($data.nasShares.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 NAS-Share is needed"
                return
            }
        }

        It -Name 'retrieves single NAS-Share by Id' -Test {
            $nasShareWithGivenId = Get-RscNasShare -Id $data.nasShares[0].id
            $nasShareWithGivenId.name | Should -Be $data.nasShares[0].name
            $nasShareWithGivenId.id | Should -Be $data.nasShares[0].id
        }

        It -Name 'retrieves single NAS-Share by Name' -Test {
            $nasSharesWithGivenName = Get-RscNasShare -Name $data.nasShares[0].name
            $nasSharesWithGivenName.Count | Should -BeGreaterThan 0
            # One of the NAS-Share in the list should have an id of $data.nasShares[0].id
            $match = $false
            foreach ($nasShare in $nasSharesWithGivenName) {
                if ($nasShare.id -eq $data.nasShares[0].id) {
                    $match = $true
                    break
                }
            }
            $match | Should -Be $true
        }

        It -Name 'retrieves single NAS-System by Id' -Test {
            $nasSystemId = $data.nasSystems[0].id
            $nasSystemName = $data.nasSystems[0].name
            $nasSystemWithGivenName = Get-RscNasSystem -Id $nasSystemId
            $nasSystemWithGivenName.name | Should -Be $nasSystemName
            $nasSystemWithGivenName.id | Should -Be $nasSystemId
        
            $nasSharesForGivenNasSystemQuery = $nasSystemWithGivenName | Get-RscNasShare -AsQuery
            $nasSharesForGivenNasSystemQuery.Field.DescendantConnection.Nodes[0].NasSystem = New-Object -TypeName RubrikSecurityCloud.Types.NasSystem
            $nasSharesForGivenNasSystemQuery.Field.DescendantConnection.Nodes[0].NasSystem.Id = "Fetch"
            $result = $nasSharesForGivenNasSystemQuery.Invoke()
            $nasSharesForGivenNasSystem = $result.DescendantConnection.Nodes

            foreach ($nasShare in $nasSharesForGivenNasSystem) {
                $nasShare.NasSystem.Id | Should -Be $nasSystemId
            }
        }
    }

}