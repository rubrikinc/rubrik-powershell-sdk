<#
.SYNOPSIS
When Invoke-Rsc pages through a connection, it needs
pageInfo.hasNextPage and pageInfo.endCursor. It selects whichever
of them the caller left out, and puts the query back afterwards.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"

    $method = [RubrikSecurityCloud.PowerShell.Cmdlets.Invoke_Rsc].GetMethod(
        'SelectPageInfoForPaging',
        [System.Reflection.BindingFlags]'Static,NonPublic')

    # Selects the pageInfo fields on the query's Field and
    # returns the action that undoes it.
    function SelectPageInfo {
        param ($query)
        return $method.Invoke($null, @(, $query.Field))
    }

    # The pageInfo selection in the query document, or $null.
    function PageInfoSelection {
        param ($query)
        $doc = $query.GqlRequest().Query -replace '\s+', ' '
        if ($doc -match 'pageInfo \{([^}]*)\}') { return $Matches[1] }
        return $null
    }
}

Describe -Name "Invoke-Rsc selects pageInfo for paging" -Fixture {

    It -Name "selects hasNextPage and endCursor when pageInfo is not selected" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -AddField Nodes.Id
        PageInfoSelection $q | Should -BeNullOrEmpty

        $undo = SelectPageInfo $q
        $sel = PageInfoSelection $q
        $sel | Should -Match '\bhasNextPage\b'
        $sel | Should -Match '\bendCursor\b'

        $undo.Invoke()
        PageInfoSelection $q | Should -BeNullOrEmpty
        $q.Field.PageInfo | Should -BeNullOrEmpty
    }

    It -Name "adds endCursor when only hasNextPage is selected" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -AddField Nodes.Id, PageInfo.HasNextPage
        PageInfoSelection $q | Should -Not -Match '\bendCursor\b'

        $undo = SelectPageInfo $q
        PageInfoSelection $q | Should -Match '\bendCursor\b'

        $undo.Invoke()
        $sel = PageInfoSelection $q
        $sel | Should -Match '\bhasNextPage\b'
        $sel | Should -Not -Match '\bendCursor\b'
    }

    It -Name "leaves a query that already selects both unchanged" -Test {
        $q = New-RscQueryVsphereVm -Op NewList -FieldProfile EMPTY -AddField Nodes.Id, PageInfo.HasNextPage, PageInfo.EndCursor
        $before = $q.GqlRequest().Query

        $undo = SelectPageInfo $q
        $q.GqlRequest().Query | Should -Be $before
        $undo.Invoke()
        $q.GqlRequest().Query | Should -Be $before
    }

    It -Name "does nothing for a field without a PageInfo property" -Test {
        $undo = $method.Invoke($null, @(, (New-Object RubrikSecurityCloud.Types.OracleRac)))
        { $undo.Invoke() } | Should -Not -Throw
    }
}
