BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"
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
}