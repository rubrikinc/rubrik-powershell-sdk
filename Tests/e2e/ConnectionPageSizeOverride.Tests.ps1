BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}
Describe -Name "Connection Page Size Override Tests" -Fixture {
    It -Name "Connection Page Size Overrides" -Test {
        # Retrieve the number of clusters
        $clusterCount = Get-RscCluster -Count

        # Bypass this test if there are less than 3 clusters
        if ($clusterCount -lt 3) {
            Set-ItResult -Skipped -Because "Less than 3 clusters found"
            return
        }

        $q0 = New-RscQueryCluster -Op List -Var @{First = 1}
        $clusters0 = Invoke-Rsc -Query $q0
        $clusters0.Nodes.Count | Should -Be 1

        $q1 = New-RscQueryCluster -Op List -Var @{First = 3}
        $clusters1 = Invoke-Rsc -Query $q1
        $clusters1.Nodes.Count | Should -Be 3


        # [RubrikSecurityCloud.Config]::connectionMaxPageSize
        # sets an upper limit on the 'First' variable
        $connectionMaxPageSize = [RubrikSecurityCloud.Config]::ConnectionMaxPageSize

        # Retrieve all with a page size of 1:
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = 1
        $q2 = New-RscQueryCluster -Op List
        $clusters2 = $q2.Invoke()
        $clusters2.Nodes.Count | Should -Be $clusterCount
        # same with Get-RscCluster:
        $clustersG = Get-RscCluster
        $clustersG.Nodes.Count | Should -Be $clusterCount

        # Retrieve 3 with a page size of 1:
        $q3 = New-RscQueryCluster -Op List -Var @{First = 3}
        $clusters3 = $q3.Invoke()
        $clusters3.Nodes.Count | Should -Be 3
        # same with Get-RscCluster:
        $clustersG3 = Get-RscCluster -First 3
        $clustersG3.Nodes.Count | Should -Be 3

        # Restore the original value:
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = $connectionMaxPageSize

        # Honor passed in 'after' variable:
        $q4 = New-RscQueryCluster -Op List -Var @{First = 1}
        $clusters4 = $q4.Invoke()
        $clusters4.Nodes.Count | Should -Be 1
        $q5 = New-RscQueryCluster -Op List -Var @{First = 1; After = $clusters4.PageInfo.EndCursor}
        $clusters5 = $q5.Invoke()
        $clusters5.Nodes.Count | Should -Be 1
        $clusters4.Nodes[0].Name | Should -Be $clusters3.Nodes[0].Name
        $clusters5.Nodes[0].Name | Should -Be $clusters3.Nodes[1].Name
    }
}