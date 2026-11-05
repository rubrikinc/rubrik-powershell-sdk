<#
.SYNOPSIS
An optional argument left unset must be sent as null (or omitted),
never as an empty object {}, which RSC rejects for dates, strings,
UUIDs, enums and lists. Required input objects keep their {} so
they can be filled in field by field.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"

    # The argument list of the field `newestSnapshot` in the query document.
    function NewestSnapshotArgs {
        param ($query)
        $doc = $query.GqlRequest().Query -replace '\s+', ' '
        if ($doc -match 'newestSnapshot\s*\(([^)]*)\)') { return $Matches[1] }
        return $null
    }
}

Describe -Name "Unset optional arguments" -Fixture {

    Context "Arguments on a field inside the query (ToInlineArguments)" {
        It -Name "unset newestSnapshot(beforeTime) is sent as null" -Test {
            $q = New-RscQueryVsphereVm -Op NewList -AddField Nodes.NewestSnapshot.Id
            NewestSnapshotArgs $q | Should -Be 'beforeTime:null'
            $q.GqlRequest().Query | Should -Not -Match 'beforeTime:\{\}'
        }

        It -Name "a beforeTime that is set is still sent" -Test {
            $q = New-RscQueryVsphereVm -Op NewList -AddField Nodes.NewestSnapshot.Id
            # Kind=Utc, so the rendered offset is +00:00 on any machine
            $q.Field.Nodes[0].Vars.NewestSnapshot.beforeTime = [datetime]::SpecifyKind([datetime]'2026-11-01T00:00:00', 'Utc')
            NewestSnapshotArgs $q | Should -Be 'beforeTime:"2026-11-01T00:00:00+00:00"'
        }
    }

    Context "Operation variables (Finalize)" {
        It -Name "unset optional string is omitted: Regions" -Test {
            $q = New-RscQueryMisc -Op Regions
            $q.GqlRequest().Variables | Should -Be '{}'
        }

        It -Name "unset optional UUID is omitted: allVpcsFromAws" -Test {
            $q = New-RscQueryAws -Op Vpcs
            $q.GqlRequest().Variables | Should -Be '{}'
        }

        It -Name "optional string that is set is still sent" -Test {
            $q = New-RscQueryMisc -Op Regions -Var @{ searchText = 'us-east' }
            $q.GqlRequest().Variables | Should -Be '{"searchText":"us-east"}'
        }

        It -Name "unset required input object is still sent as {}" -Test {
            $q = New-RscQueryMssql -Op RecoverableRanges
            $q.GqlRequest().Variables | Should -Be '{"input":{}}'
        }

        It -Name "required input object can still be filled in" -Test {
            $q = New-RscQueryMssql -Op RecoverableRanges
            $q.Var.input.id = 'abc'
            $q.GqlRequest().Variables | Should -Be '{"input":{"id":"abc"}}'
        }
    }
}
