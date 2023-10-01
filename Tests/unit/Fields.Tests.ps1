<#
.SYNOPSIS
Run tests around fields.
#>
BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"

    function FieldSelectionCheck {
        param(
            [Parameter(Mandatory = $true)]
            [object]$fieldSpec
        )
        $selected = $fieldSpec.SelectedFields()# -split "`n" | Where-Object { $_.Trim() -ne '' } | Sort-Object
        $unselected = $fieldSpec.UnselectedFields() #-split "`n" | Where-Object { $_.Trim() -ne '' } | Sort-Object
        $all = $fieldSpec.AllFields() | sort-object # -split "`n" | Where-Object { $_.Trim() -ne '' } | Sort-Object
        ($selected + $unselected) | Sort-Object | Should -Be $all
    }
}

Describe -Name "Test fields" -Fixture {
    It -Name "Test fields" -Test {
        $q0 = New-RscQueryVsphere -Op TopLevelDescendantsList

        # make sure the schema hasn't changed:
        $q0.Field.GetType().FullName | Should -Be "RubrikSecurityCloud.Types.CdmHierarchyObjectConnection"

        # Not recommended, but it works:
        # You can give fields from a different type of object
        # as input. The query will only retain the fields that
        # coincide with the type of Field the query needs
        $q1 = New-RscQueryCluster -Op List
        $q2 = New-RscQueryVsphere -Op TopLevelDescendantsList -Field $q1.Field

        # SelectedFields(), AllFields() and UnselectedFields()
        $q3 = New-RscQueryAccount -op Products -FieldProfile FULL
        $q3.Field.SelectedFields() | Should -Be $q3.Field.AllFields()
        $q3.Field.UnselectedFields() | Should -Be $null

        FieldSelectionCheck ((New-RscQueryAccount -op EnabledFeatures).Field)
        FieldSelectionCheck ((New-RscQueryAccount -op Lookup).Field)
        FieldSelectionCheck (New-RscQueryAccount -op Owners).Field
        FieldSelectionCheck ((New-RscQueryAccount -op Products).Field)
        FieldSelectionCheck (New-RscQueryAccount -op Settings).Field
        FieldSelectionCheck (New-RscQueryAccount -op Users).Field
        FieldSelectionCheck (New-RscMutationVsphereVm -op DownloadSnapshot).Field
        FieldSelectionCheck (New-RscQueryCluster -op List).Field
        
        # Return type for Account.Id is a scalar
        # so there are no fields to select
        $f = (New-RscQueryAccount -op Id).Field
        { $f.AllFields() } | Should -Throw
    }
}