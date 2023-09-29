<#
.SYNOPSIS
Run tests around fields.
#>
BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"
}

Describe -Name "Test fields" -Fixture {
    It -Name "With New-RscQueryVsphere -TopLevelDescendantsList" -Test {
        $q0 = New-RscQueryVsphere -TopLevelDescendantsList

        # make sure the schema hasn't changed:
        $q0.Field.GetType().FullName | Should -Be "RubrikSecurityCloud.Types.CdmHierarchyObjectConnection"

        # Not recommended, but it works:
        # You can give fields from a different type of object
        # as input. The query will only retain the fields that
        # coincide with the type of Field the query needs
        $q1 = New-RscQueryCluster -List
        $q2 = New-RscQueryVsphere -TopLevelDescendantsList -Field $q1.Field
    }
}