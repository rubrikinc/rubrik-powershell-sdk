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

Describe -Name "Get-RscSla archival location fields" -Fixture {

    It -Name "archivalSpecs includes cluster.name, location.name, and location.targetType" -Test {
        $query = Get-RscSla -AsQuery
        $gsr = $query.field.nodes |
            Where-Object { $_.GetType().Name -eq "GlobalSlaReply" } |
            Select-Object -First 1
        $mapping = $gsr.ArchivalSpecs[0].ArchivalLocationToClusterMapping[0]
        $mapping.Cluster.Id   | Should -Not -BeNullOrEmpty
        $mapping.Cluster.Name | Should -Not -BeNullOrEmpty
        $mapping.Location.Id  | Should -Not -BeNullOrEmpty
        $mapping.Location.Name | Should -Not -BeNullOrEmpty
        $mapping.Location.AsFieldSpec() | Should -Match "targetType"
    }

    It -Name "cascadingArchivalSpecs includes archivalLocationToClusterMapping with multi-type location" -Test {
        $query = Get-RscSla -AsQuery
        $gsr = $query.field.nodes |
            Where-Object { $_.GetType().Name -eq "GlobalSlaReply" } |
            Select-Object -First 1
        $mapping = $gsr.ReplicationSpecsV2[0].CascadingArchivalSpecs[0].ArchivalLocationToClusterMapping[0]
        $mapping.Cluster.Id   | Should -Not -BeNullOrEmpty
        $mapping.Cluster.Name | Should -Not -BeNullOrEmpty
        $fs = $mapping.Location.AsFieldSpec()
        $fs | Should -Match "on RubrikManagedAwsTarget"
        $fs | Should -Match "on RubrikManagedAzureTarget"
        $fs | Should -Match "on RubrikManagedGcpTarget"
        $fs | Should -Match "on CdmManagedAwsTarget"
        $fs | Should -Match "on CdmManagedGcpTarget"
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
