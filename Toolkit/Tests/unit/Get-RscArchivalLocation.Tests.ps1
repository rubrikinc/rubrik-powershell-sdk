<#
.SYNOPSIS
Tests for Get-RscArchivalLocation GroupType filtering.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "Get-RscArchivalLocation Tests" -Fixture {

    It 'no -GroupType: no ARCHIVAL_GROUP_TYPE filter in variables' {
        $q = Get-RscArchivalLocation -AsQuery
        $groupFilter = $q.var.filter | Where-Object {
            $_.field -eq [RubrikSecurityCloud.Types.TargetMappingQueryFilterField]::ARCHIVAL_GROUP_TYPE
        }
        $groupFilter | Should -BeNullOrEmpty
    }

    It '-GroupType CLOUD_NATIVE_ARCHIVAL_GROUP: filter is set correctly' {
        $q = Get-RscArchivalLocation -GroupType CLOUD_NATIVE_ARCHIVAL_GROUP -AsQuery
        $groupFilter = $q.var.filter | Where-Object {
            $_.field -eq [RubrikSecurityCloud.Types.TargetMappingQueryFilterField]::ARCHIVAL_GROUP_TYPE
        }
        $groupFilter | Should -Not -BeNullOrEmpty
        $groupFilter.text | Should -Be "CLOUD_NATIVE_ARCHIVAL_GROUP"
    }

    It '-GroupType DATACENTER_ARCHIVAL_GROUP: filter is set correctly' {
        $q = Get-RscArchivalLocation -GroupType DATACENTER_ARCHIVAL_GROUP -AsQuery
        $groupFilter = $q.var.filter | Where-Object {
            $_.field -eq [RubrikSecurityCloud.Types.TargetMappingQueryFilterField]::ARCHIVAL_GROUP_TYPE
        }
        $groupFilter | Should -Not -BeNullOrEmpty
        $groupFilter.text | Should -Be "DATACENTER_ARCHIVAL_GROUP"
    }

    It '-Name filter works independently of -GroupType' {
        $q = Get-RscArchivalLocation -Name "S3-Prod" -AsQuery
        $nameFilter = $q.var.filter | Where-Object {
            $_.field -eq [RubrikSecurityCloud.Types.TargetMappingQueryFilterField]::NAME
        }
        $nameFilter | Should -Not -BeNullOrEmpty
        $nameFilter.text | Should -Be "S3-Prod"
        # No group type filter
        $groupFilter = $q.var.filter | Where-Object {
            $_.field -eq [RubrikSecurityCloud.Types.TargetMappingQueryFilterField]::ARCHIVAL_GROUP_TYPE
        }
        $groupFilter | Should -BeNullOrEmpty
    }

    It '-Name and -GroupType can be combined' {
        $q = Get-RscArchivalLocation -Name "S3-Prod" -GroupType CLOUD_NATIVE_ARCHIVAL_GROUP -AsQuery
        $q.var.filter.Count | Should -Be 2
    }
}
