<#
.SYNOPSIS
Tests for Get-RscSnapshot, including -Latest sort order (discussion #218).
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "Get-RscSnapshot -Latest" -Fixture {

    BeforeAll {
        $script:vm = New-Object RubrikSecurityCloud.Types.VsphereVm
        $script:vm.Id = '00000000-0000-0000-0000-000000000000'
    }

    It -Name 'Latest query requests the newest snapshot by creation time' -Test {
        $query = Get-RscSnapshot -InputObject $script:vm -Latest -AsQuery
        $query | Should -Not -BeNullOrEmpty
        $query.Var.first | Should -Be 1
        $query.Var.sortBy | Should -Be ([RubrikSecurityCloud.Types.SnapshotQuerySortByField]::CREATION_TIME)
        $query.Var.sortOrder | Should -Be ([RubrikSecurityCloud.Types.SortOrder]::DESC)
        $gql = $query.GqlRequest().Query
        $gql | Should -Match 'snapshotOfASnappableConnection'
    }

    It -Name 'List query does not pin first/sort to a single newest snapshot' -Test {
        $query = Get-RscSnapshot -InputObject $script:vm -AsQuery
        $query | Should -Not -BeNullOrEmpty
        $query.Var.first | Should -BeNullOrEmpty
        $query.Var.sortBy | Should -BeNullOrEmpty
        $query.Var.sortOrder | Should -BeNullOrEmpty
    }
}
