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

Describe -Name "Get-RscSla extended cascading archival coverage" -Fixture {

    BeforeAll {
        $query = Get-RscSla -AsQuery
        $script:gsr = $query.field.nodes |
            Where-Object { $_.GetType().Name -eq "GlobalSlaReply" } |
            Select-Object -First 1
        $script:locFs = $script:gsr.ReplicationSpecsV2[0].CascadingArchivalSpecs[0].ArchivalLocationToClusterMapping[0].Location.AsFieldSpec()
    }

    It -Name "chain includes all 22 Target implementations" -Test {
        $types = @(
            'RubrikManagedAwsTarget', 'RubrikManagedAzureTarget', 'RubrikManagedGcpTarget',
            'RubrikManagedNfsTarget', 'RubrikManagedS3CompatibleTarget',
            'RubrikManagedDcaTarget', 'RubrikManagedGlacierTarget',
            'RubrikManagedLckTarget', 'RubrikManagedTapeTargetType',
            'CdmManagedAwsTarget', 'CdmManagedAzureTarget', 'CdmManagedGcpTarget',
            'CdmManagedNfsTarget', 'CdmManagedS3CompatibleTarget',
            'CdmManagedDcaTarget', 'CdmManagedGlacierTarget',
            'CdmManagedLckTarget', 'CdmManagedTapeTarget', 'CdmTarget',
            'RubrikManagedRcvAwsTarget', 'RubrikManagedRcvGcpTarget',
            'RubrikManagedRcsTarget'
        )
        foreach ($t in $types) {
            $script:locFs | Should -Match "on $t"
        }
    }

    It -Name "Target-interface scalar fields are selected on the chain" -Test {
        $script:locFs | Should -Match "clusterName"
        $script:locFs | Should -Match "status"
        $script:locFs | Should -Match "upgradeStatus"
        $script:locFs | Should -Match "locationConnectionStatus"
        $script:locFs | Should -Match "locationScope"
        $script:locFs | Should -Match "readerRetrievalMethod"
        $script:locFs | Should -Match "targetType"
    }

    It -Name "TargetMapping and TargetMappingBasic are selected on the chain" -Test {
        $script:locFs | Should -Match "targetMapping"
        $script:locFs | Should -Match "targetMappingBasic"
    }

    It -Name "RubrikManaged* targets select connectionStatus and syncStatus" -Test {
        $script:locFs | Should -Match "connectionStatus"
        $script:locFs | Should -Match "syncStatus"
    }

    It -Name "Rcv/Rcs targets select tier and redundancy" -Test {
        $script:locFs | Should -Match "tier"
        $script:locFs | Should -Match "redundancy"
    }

    It -Name "RubrikManagedRcsTarget selects redundancyState" -Test {
        # redundancyState exists only on RubrikManagedRcsTarget
        $script:locFs | Should -Match "redundancyState"
    }

    It -Name "ReplicationSpecsV2.TargetMapping selects connectionStatus, groupType, id, name, targetType" -Test {
        $tm = $script:gsr.ReplicationSpecsV2[0].TargetMapping
        $tm | Should -Not -BeNullOrEmpty
        $tm.GetType().Name | Should -Be "TargetMapping"
        $tmFs = $tm.AsFieldSpec()
        # connectionStatus is itself a type (ArchivalGroupConnectionStatus) with a
        # status sub-field — the path selects connectionStatus.status.
        $tm.ConnectionStatus | Should -Not -BeNullOrEmpty
        $tm.ConnectionStatus.AsFieldSpec() | Should -Match "status"
        $tmFs | Should -Match "groupType"
        $tmFs | Should -Match "id"
        $tmFs | Should -Match "name"
        $tmFs | Should -Match "targetType"
    }
}
