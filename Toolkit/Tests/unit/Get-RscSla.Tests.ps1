<#
.SYNOPSIS
Unit tests for Get-RscSla — verify the composite chain lookup
used in the slaDomain (by-ID) and slaDomains (list) code paths.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "Get-RscSla composite chain lookup" -Fixture {

    It -Name "slaDomain: AsList() returns both ClusterSlaDomain and GlobalSlaReply" -Test {
        $query = New-RscQuery -GqlQuery slaDomain
        $nodes = $query.field.AsList()
        $nodes.Count | Should -BeGreaterOrEqual 2
        $cdm = $nodes["ClusterSlaDomain"]
        $gsr = $nodes["GlobalSlaReply"]
        $cdm | Should -Not -BeNullOrEmpty
        $gsr | Should -Not -BeNullOrEmpty
        $cdm.GetType().Name | Should -Be "ClusterSlaDomain"
        $gsr.GetType().Name | Should -Be "GlobalSlaReply"
    }

    It -Name "slaDomains: nodes list contains a GlobalSlaReply element" -Test {
        $query = New-RscQuery -GqlQuery slaDomains
        $gsr = $query.field.nodes |
            Where-Object { $_.GetType().Name -eq "GlobalSlaReply" } |
            Select-Object -First 1
        $gsr | Should -Not -BeNullOrEmpty
        $gsr.GetType().Name | Should -Be "GlobalSlaReply"
    }
}

Describe -Name "Get-RscSla -AsQuery" -Fixture {

    It -Name "List path: -AsQuery returns a query object" -Test {
        $query = Get-RscSla -AsQuery
        $query | Should -Not -BeNullOrEmpty
        $query.field | Should -Not -BeNullOrEmpty
        $query.var | Should -Not -BeNullOrEmpty
    }

    It -Name "Id path: -AsQuery returns a query object" -Test {
        $query = Get-RscSla -Id "dummy-id" -AsQuery
        $query | Should -Not -BeNullOrEmpty
        $query.field | Should -Not -BeNullOrEmpty
        $query.var | Should -Not -BeNullOrEmpty
    }
}
