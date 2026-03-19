<#
.SYNOPSIS
Tests for Get-RscEventSeries, including the -Detail flag fix (#208).
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "Get-RscEventSeries" -Fixture {

    It -Name 'Default query generates valid GQL' -Test {
        $query = Get-RscEventSeries -First 1 -AsQuery
        $query | Should -Not -BeNullOrEmpty
        $gql = $query.GqlRequest().Query
        $gql | Should -Match 'activitySeriesConnection'
    }

    It -Name 'Detail query by Id generates valid GQL' -Test {
        $query = Get-RscEventSeries -Id '00000000-0000-0000-0000-000000000000' -Detail -AsQuery
        $query | Should -Not -BeNullOrEmpty
        $gql = $query.GqlRequest().Query
        $gql | Should -Match 'activitySeries'
    }

    It -Name 'Detail query does not include metricTimeSeriesNew (#208)' -Test {
        # Single-item query (QueryActivitySeries)
        $query = Get-RscEventSeries -Id '00000000-0000-0000-0000-000000000000' -Detail -AsQuery
        $gql = $query.GqlRequest().Query
        $gql | Should -Not -Match 'metricTimeSeriesNew'

        # List query (QueryActivitySeriesConnection)
        $queryList = Get-RscEventSeries -First 1 -Detail -AsQuery
        $gqlList = $queryList.GqlRequest().Query
        $gqlList | Should -Not -Match 'metricTimeSeriesNew'
    }
}
