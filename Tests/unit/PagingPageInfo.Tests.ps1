<#
.SYNOPSIS
When Invoke-Rsc pages through a connection, it needs
pageInfo.hasNextPage and pageInfo.endCursor. It selects whichever
of them the caller left out, puts the query back afterwards, and
returns only the fields the caller selected.

The paging loop is driven with a fake sendPage that serves 5 VMs,
so no server is needed.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"

    $flags = [System.Reflection.BindingFlags]'Static,NonPublic'
    $script:collatePages = [RubrikSecurityCloud.PowerShell.Cmdlets.Invoke_Rsc].GetMethod('CollatePages', $flags)
    $script:selectPageInfo = [RubrikSecurityCloud.PowerShell.Cmdlets.Invoke_Rsc].GetMethod('SelectPageInfoForPaging', $flags)

    # Builds a fake sendPage serving $Total VMs. Each request is
    # recorded in $script:requests. With -NoCursor the server says
    # there are more pages but never sends a cursor.
    function New-FakeSendPage {
        param ([int]$Total = 5, [switch]$NoCursor, [switch]$Throw)
        $requests = [System.Collections.Generic.List[object]]::new()
        $script:requests = $requests
        # Typed return so PowerShell hands back the object itself, not a
        # PSObject wrapper (the paging code reads its properties by reflection).
        return [System.Func[RubrikSecurityCloud.RscGqlRequest, RubrikSecurityCloud.Types.VsphereVmConnection]] {
            param ($req)
            if ($Throw) { throw "send failed" }
            $vars = $req.Variables | ConvertFrom-Json
            $requests.Add([pscustomobject]@{ Vars = $vars; Query = $req.Query })
            $first = if ($null -ne $vars.first) { [int]$vars.first } else { $Total }
            $start = if ($vars.after) { [int]$vars.after } else { 0 }
            $end = [Math]::Min($start + $first, $Total)

            $conn = New-Object RubrikSecurityCloud.Types.VsphereVmConnection
            if ($req.Query -match '\bnodes\b') {
                $conn.Nodes = [System.Collections.Generic.List[RubrikSecurityCloud.Types.VsphereVm]]::new()
                for ($i = $start + 1; $i -le $end; $i++) {
                    $vm = New-Object RubrikSecurityCloud.Types.VsphereVm
                    $vm.Id = "vm-$i"
                    $conn.Nodes.Add($vm)
                }
            }
            if ($req.Query -match 'pageInfo') {
                $conn.PageInfo = New-Object RubrikSecurityCloud.Types.PageInfo
                if ($req.Query -match '\bhasNextPage\b') { $conn.PageInfo.HasNextPage = $NoCursor -or ($end -lt $Total) }
                if ($req.Query -match '\bendCursor\b' -and -not $NoCursor) { $conn.PageInfo.EndCursor = "$end" }
            }
            return $conn
        }.GetNewClosure()
    }

    function Invoke-CollatePages {
        param ($query, $sendPage)
        try {
            $invokeArgs = [object[]]@($query.psobject.BaseObject, $sendPage, $null)
            return $script:collatePages.Invoke($null, $invokeArgs)
        } catch [System.Reflection.TargetInvocationException] {
            throw $_.Exception.InnerException
        }
    }

    function NodeIds { param ($result) ($result.Nodes | ForEach-Object { $_.Id }) -join ',' }
}

Describe -Name "Invoke-Rsc paging" -Fixture {
    BeforeEach {
        $script:savedPageSize = [RubrikSecurityCloud.Config]::ConnectionMaxPageSize
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = 2
    }
    AfterEach {
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = $script:savedPageSize
    }

    It -Name "pages a query that does not select pageInfo" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -Var @{ first = 4 } -AddField Nodes.Id
        $r = Invoke-CollatePages $q (New-FakeSendPage)

        NodeIds $r | Should -Be 'vm-1,vm-2,vm-3,vm-4'
        $script:requests[0].Query | Should -Match '\bendCursor\b'
        $script:requests[0].Query | Should -Match '\bhasNextPage\b'
        # Result and query only have what the caller selected.
        $r.PageInfo | Should -BeNullOrEmpty
        $q.Field.PageInfo | Should -BeNullOrEmpty
        $q.Var['first'] | Should -Be 4
    }

    It -Name "pages a query without -Var (first is pre-filled with null)" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -AddField Nodes.Id
        $r = Invoke-CollatePages $q (New-FakeSendPage)

        NodeIds $r | Should -Be 'vm-1,vm-2,vm-3,vm-4,vm-5'
        $q.Var['first'] | Should -BeNullOrEmpty
    }

    It -Name "adds endCursor when only hasNextPage is selected, and keeps it out of the result" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -Var @{ first = 4 } -AddField Nodes.Id, PageInfo.HasNextPage
        $r = Invoke-CollatePages $q (New-FakeSendPage)

        NodeIds $r | Should -Be 'vm-1,vm-2,vm-3,vm-4'
        $r.PageInfo.HasNextPage | Should -Not -BeNullOrEmpty
        $r.PageInfo.EndCursor | Should -BeNullOrEmpty
        $q.Field.PageInfo.HasNextPage | Should -Not -BeNullOrEmpty
        $q.Field.PageInfo.EndCursor | Should -BeNullOrEmpty
    }

    It -Name "keeps pageInfo in the result when the caller selected it" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -Var @{ first = 4 } -AddField Nodes.Id, PageInfo.HasNextPage, PageInfo.EndCursor
        $r = Invoke-CollatePages $q (New-FakeSendPage)

        $r.PageInfo.EndCursor | Should -Be '4'
    }

    It -Name "does not select pageInfo on a count-only query" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -AddField Count
        $null = Invoke-CollatePages $q (New-FakeSendPage)

        $script:requests.Count | Should -Be 1
        $script:requests[0].Query | Should -Not -Match 'pageInfo'
    }

    It -Name "keeps the caller's after cursor" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -Var @{ first = 2; after = '2' } -AddField Nodes.Id
        $r = Invoke-CollatePages $q (New-FakeSendPage)

        NodeIds $r | Should -Be 'vm-3,vm-4'
        $q.Var['after'] | Should -Be '2'
    }

    It -Name "stops instead of refetching when a page has no endCursor" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -AddField Nodes.Id
        $r = Invoke-CollatePages $q (New-FakeSendPage -NoCursor)

        $script:requests.Count | Should -Be 1
        NodeIds $r | Should -Be 'vm-1,vm-2'
    }

    It -Name "uses the server's page size when ConnectionMaxPageSize is 0 and first is null" -Test {
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = 0
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -AddField Nodes.Id
        $r = Invoke-CollatePages $q (New-FakeSendPage)

        $script:requests[0].Vars.first | Should -BeNullOrEmpty
        NodeIds $r | Should -Be 'vm-1,vm-2,vm-3,vm-4,vm-5'
    }

    It -Name "puts the query back when sending fails" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -Var @{ first = 4 } -AddField Nodes.Id
        { Invoke-CollatePages $q (New-FakeSendPage -Throw) } | Should -Throw '*send failed*'

        $q.Field.PageInfo | Should -BeNullOrEmpty
        $q.Var['first'] | Should -Be 4
    }

    It -Name "SelectPageInfoForPaging does nothing for a type without PageInfo" -Test {
        $unselect = $script:selectPageInfo.Invoke($null, @(, (New-Object RubrikSecurityCloud.Types.OracleRac)))
        { $unselect.Invoke($null) } | Should -Not -Throw
    }
}
