<#
.SYNOPSIS
Run tests around fields.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "Test Empty Profile" -Fixture {
    It -Name "With `Empty` FieldProfile and adding fields using AddField parameter" -Test {
        $expectedMutation = "mutation MutationBeginManagedVolumeSnapshot(`$input: BeginManagedVolumeSnapshotInput!)`n{`n  beginManagedVolumeSnapshot`n  (`n  input: `$input`n  )`n  {`n  ownerId`n  }`n}`n"
        $query = (New-RscMutationManagedVolume -Operation BeginSnapshot -FieldProfile EMPTY -AddField OwnerId).GqlRequest().Query
        $query | Should -BeExactly $expectedMutation
    }

    It -Name "With `Empty` FieldProfile and adding fields to the query" -Test {
        $expectedMutation = "mutation MutationBeginManagedVolumeSnapshot(`$input: BeginManagedVolumeSnapshotInput!)`n{`n  beginManagedVolumeSnapshot`n  (`n  input: `$input`n  )`n  {`n  ownerId`n  }`n}`n"
        $q = New-RscMutationManagedVolume -Operation BeginSnapshot -FieldProfile EMPTY
        $q.Field.OwnerId="FETCH"
        $q.GqlRequest().query | Should -BeExactly $expectedMutation
    }

    It -Name "With Empty FieldProfile and without adding any fields" -Test {
        $q = New-RscMutationManagedVolume -Operation BeginSnapshot -FieldProfile EMPTY
        try {
            $q.GqlRequest()
            $false | Should -Be $true -Because "An ArgumentException was expected but not thrown."
        } catch {
            $_.Exception.InnerException | Should -BeOfType 'System.ArgumentException'
            $_.Exception.InnerException.Message | Should -BeExactly 'No field specified. A valid GQL query requires at least one field to be included.'
        }
    }
}