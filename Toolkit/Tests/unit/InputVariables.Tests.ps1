<#
.SYNOPSIS
Toolkit commands fill an operation's input object field by field
(`$query.Var.input.id = ...`). An unset optional argument is sent as
null, but a required input object must keep its placeholder so this
keeps working.

Uses -AsQuery, so no RSC connection is needed.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"

    $dbId = '11111111-1111-1111-1111-111111111111'
    $mockMssqlDb = New-Object RubrikSecurityCloud.Types.MssqlDatabase
    $mockMssqlDb.Id = $dbId
}

Describe -Name "Toolkit input variables" -Fixture {

    It -Name "New-RscMssqlLogBackup sends the filled-in input" -Test {
        $q = New-RscMssqlLogBackup -RscMssqlDatabase $mockMssqlDb -AsQuery
        $q.GqlRequest().Variables | Should -Be "{`"input`":{`"id`":`"$dbId`"}}"
    }

    It -Name "Get-RscMssqlDatabaseRecoverableRanges sends the filled-in input" -Test {
        $q = Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $mockMssqlDb -AsQuery
        $q.GqlRequest().Variables | Should -Be "{`"input`":{`"id`":`"$dbId`"}}"
    }

    It -Name "Get-RscMssqlDatabaseRecoverableRanges sends optional fields that are set" -Test {
        $after = [datetime]::SpecifyKind([datetime]'2026-01-01T00:00:00', 'Utc')
        $q = Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $mockMssqlDb -AfterTime $after -AsQuery
        $vars = $q.GqlRequest().Variables | ConvertFrom-Json
        $vars.input.id | Should -Be $dbId
        $vars.input.afterTime | Should -Not -BeNullOrEmpty
    }

    It -Name "an empty required input object is not turned into null" -Test {
        $q = New-RscQueryMssql -Op RecoverableRanges
        $q.GqlRequest().Variables | Should -Be '{"input":{}}'
    }
}
