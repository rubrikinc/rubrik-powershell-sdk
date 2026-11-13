<#
.SYNOPSIS
Enum values in the inline arguments of a field must be written without
quotes (sortOrder:DESC), as GraphQL requires. Quoted, they are strings
and RSC rejects the query. Strings and dates keep their quotes, and the
JSON variables keep sending enums as quoted strings.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"

    function NewVarSet {
        param ([hashtable]$Vars)
        $dict = New-Object 'System.Collections.Generic.Dictionary[string,object]'
        foreach ($k in $Vars.Keys) { $dict[$k] = $Vars[$k] }
        $set = New-Object RubrikSecurityCloud.OperationVariableSet
        $set.Variables = $dict
        return $set
    }

    function InlineArgs {
        param ([hashtable]$Vars)
        return (NewVarSet $Vars).AsInlineVariables()
    }

    function NewSort {
        $sort = New-Object RubrikSecurityCloud.Types.FileResultSortInput
        $sort.sortBy = [RubrikSecurityCloud.Types.FileResultSortBy]::HITS
        $sort.sortOrder = [RubrikSecurityCloud.Types.SortOrder]::DESC
        return $sort
    }
}

Describe -Name "Enums in inline arguments" -Fixture {

    It -Name "an enum on its own is written bare" -Test {
        InlineArgs @{ sortOrder = [RubrikSecurityCloud.Types.SortOrder]::ASC } |
            Should -Be 'sortOrder:ASC'
    }

    It -Name "an enum inside an input object is written bare" -Test {
        InlineArgs @{ sort = (NewSort) } |
            Should -Be 'sort:{sortBy:HITS,sortOrder:DESC}'
    }

    It -Name "strings next to enums keep their quotes" -Test {
        $filter = New-Object RubrikSecurityCloud.Types.ListFileResultFiltersInput
        $filter.FileType = [RubrikSecurityCloud.Types.FileCountType]::HITS
        $filter.searchText = 'report'
        $filter.whitelistEnabled = $true

        InlineArgs @{ filter = $filter } |
            Should -Be 'filter:{fileType:HITS,searchText:"report",whitelistEnabled:true}'
    }

    It -Name "a list of enums inside an input object is written bare" -Test {
        $filter = New-Object RubrikSecurityCloud.Types.BrowseDirectoryFiltersInput
        $filter.RiskLevelTypesFilter = [System.Collections.Generic.List[RubrikSecurityCloud.Types.RiskLevelType]]@(
            [RubrikSecurityCloud.Types.RiskLevelType]::HIGH_RISK,
            [RubrikSecurityCloud.Types.RiskLevelType]::LOW_RISK)

        InlineArgs @{ filter = $filter } |
            Should -Be 'filter:{riskLevelTypesFilter:[HIGH_RISK,LOW_RISK]}'
    }

    It -Name "an enum in a nested input object is written bare" -Test {
        $config = New-Object RubrikSecurityCloud.Types.ManagedVolumeConfigInput
        $config.MvType = [RubrikSecurityCloud.Types.CdmManagedVolumeType]::MANAGED_VOLUME_TYPE_SLA_BASED
        $input = New-Object RubrikSecurityCloud.Types.AddManagedVolumeInput
        $input.ManagedVolumeConfig = $config
        $input.ClusterUuid = 'abc'

        InlineArgs @{ input = $input } |
            Should -Be 'input:{clusterUuid:"abc",managedVolumeConfig:{mvType:MANAGED_VOLUME_TYPE_SLA_BASED}}'
    }

    It -Name "an enum with a GraphQL name that differs from the C# name uses the GraphQL name" -Test {
        $config = New-Object RubrikSecurityCloud.Types.CustomReportFiltersConfig
        $config.ActivityObjectType = [System.Collections.Generic.List[RubrikSecurityCloud.Types.ActivityObjectTypeEnum]]@(
            [RubrikSecurityCloud.Types.ActivityObjectTypeEnum]::APP_BLUEPRINT)

        InlineArgs @{ filter = $config } |
            Should -Be 'filter:{activityObjectType:[AppBlueprint]}'
    }

    It -Name "a string that looks like an enum stays quoted" -Test {
        InlineArgs @{ timezone = 'DESC' } | Should -Be 'timezone:"DESC"'

        $sort = New-Object RubrikSecurityCloud.Types.FileResultSortInput
        $sort.dataTypeId = 'DESC'
        InlineArgs @{ sort = $sort } | Should -Be 'sort:{dataTypeId:"DESC"}'
    }

    It -Name "an unset enum inside an object is omitted" -Test {
        $sort = New-Object RubrikSecurityCloud.Types.FileResultSortInput
        $sort.dataTypeId = 'x'
        InlineArgs @{ sort = $sort } | Should -Be 'sort:{dataTypeId:"x"}'
    }

    It -Name "a date inside an input object is written as a quoted timestamp" -Test {
        $filter = New-Object RubrikSecurityCloud.Types.ActivitySeriesFilter
        # Kind=Utc, so the rendered offset is +00:00 on any machine
        $filter.LastUpdatedTimeGt = [datetime]::SpecifyKind([datetime]'2026-01-02T03:04:05', 'Utc')

        InlineArgs @{ filter = $filter } |
            Should -Be 'filter:{lastUpdatedTimeGt:"2026-01-02T03:04:05+00:00"}'
    }

    It -Name "the JSON variables keep the enum as a quoted string" -Test {
        (NewVarSet @{ sort = (NewSort) }).AsJson() |
            Should -Be '{"sort":{"sortBy":"HITS","sortOrder":"DESC"}}'
    }

    It -Name "the JSON variables are unchanged after writing inline arguments" -Test {
        $set = NewVarSet @{ sort = (NewSort) }
        $null = $set.AsInlineVariables()
        $set.AsJson() | Should -Be '{"sort":{"sortBy":"HITS","sortOrder":"DESC"}}'
    }
}

Describe -Name "SPARK-634214: policyObj fileResultConnection" -Fixture {

    It -Name "sort and filter enums are not quoted in the query document" -Test {
        $q = New-RscQuery -GqlQuery policyObj -AddField FileResultConnection
        $q.Field.FileResultConnection = New-Object RubrikSecurityCloud.Types.FileResultConnection
        $q.Field.FileResultConnection.Count = 1

        $filter = New-Object RubrikSecurityCloud.Types.ListFileResultFiltersInput
        $filter.FileType = [RubrikSecurityCloud.Types.FileCountType]::HITS

        $q.Var.snappableFid = 'de40d620-0459-5788-ad63-e953bfe49551'
        $q.Var.snapshotFid = '1d15a14a-3d66-5b37-bbf8-b6bb10eaeae0'
        $q.Field.Vars.FileResultConnection.filter = $filter
        $q.Field.Vars.FileResultConnection.sort = (NewSort)
        $q.Field.Vars.FileResultConnection.timezone = 'America/New_York'

        $doc = $q.GqlRequest().Query -replace '\s+', ' '
        $doc | Should -Match 'filter:\{fileType:HITS\}'
        $doc | Should -Match 'sort:\{sortBy:HITS,sortOrder:DESC\}'
        $doc | Should -Match 'timezone:"America/New_York"'
        $doc | Should -Not -Match '"(HITS|DESC)"'
    }
}
