BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        objects = $null
    }
}

Describe -Name 'Get-RscMssqlAvailabilityGroup Tests' -Tag 'Public' -Fixture {

    It -Name 'creates a query' -Test {
        $query = Get-RscMssqlAvailabilityGroup -AsQuery
        $query | Should -BeOfType [RubrikSecurityCloud.RscQuery]
    }
}

