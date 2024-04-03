BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}
Describe -Name "TEST Json serialization" -Fixture {
    It -Name "List of enum values" -Test {
        $typeFilter = @(
            [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::WINDOWS_CLUSTER ,
            [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::PHYSICAL_HOST)
        $q = New-RscQueryVsphere -Op TopLevelDescendantsList -Var @{
            typeFilter = $typeFilter
        }
        { $g = $q.GqlRequest() } | Should -Not -Throw
    }

    It -Name "Subfield arguments" -Test {
        $filter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
        $filter.Texts = @("hello", "world")
        $filter.isNegative = $true
        $filter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::ACTIVE_DIRECTORY_DOMAIN_NAME
        $virtualDiskFilter = New-Object -TypeName RubrikSecurityCloud.Types.VsphereVirtualDiskFilter
        $virtualDiskFilter.FileName = "filename"
        $vmquery = New-RscQueryVspherevm -operation NewList
        $vmquery.Field.nodes[0].VsphereVirtualDisks = New-Object -TypeName RubrikSecurityCloud.Types.VsphereVirtualDiskConnection
        $vmquery.Var.filter = $filter
        $vmquery.Field.nodes[0].Vars.VsphereVirtualDisks.filter = $virtualDiskFilter
        $vmquery.Field.Nodes[0].VsphereVirtualDisks.Count = 1

        { $vmquery.GqlRequest() } | Should -Not -Throw
    }
}
