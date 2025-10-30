BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        logShipping = Get-RscMssqlLogShipping
    }
}

Describe -Name 'Get-RscMssqlLogShipping Tests' -Tag 'Public' -Fixture {

    Context -Name 'LogShippingTarget Count > 0' {
        BeforeEach {
            # Skip the tests if empty LogShippingTarget list
            if ($data.logShipping.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 LogShippingTarget is needed"
                return
            }
        }

        It -Name 'retrieves single LogShippingTarget by Id' -Test {
            $logShipping0 = Get-RscMssqlLogShipping -Id $data.logShipping[0].id
            $logShipping0.id | Should -Be $data.logShipping[0].id
        }

        It -Name 'retrieves LogShippingTarget using filters' -Test {
            $logShipping0 = Get-RscMssqlLogShipping -PrimaryDatabase (Get-RscMssqlDatabase -id $data.logShipping[0].primaryDatabase.Id) -SecondaryDatabaseName $data.logShipping[0].SecondaryDatabase.name
            $logShipping0.id | Should -Be $data.logShipping[0].id
        }
        

    }

}
