BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}
Describe -Name "Connection Page Size Overrides" -Fixture {
    It -Name "Connection Page Size Overrides" -Test {
        # Retrieve the number of clusters
        $clusterCount = Get-RscCluster -Count

        # Bypass this test if there are less than 2 clusters
        if ($clusterCount -lt 2) {
            Set-ItResult -Skipped -Because "Less than 2 clusters found"
            return
        }

        # [RubrikSecurityCloud.Config]::connectionMaxPageSize
        # sets an upper limit on the 'First' variable

        $connectionMaxPageSize = [RubrikSecurityCloud.Config]::ConnectionMaxPageSize

        # Disable max page size (at the SDK level, the API server
        # still has a limit)
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = 0
        $q = New-RscQueryCluster -Op List
        $clusters0 = Invoke-Rsc -Query $q -Verbose
        $clusters0.Nodes.Count | Should -Be $clusterCount

        # Limit to 1 cluster:
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = 1
        $clusters1 = (New-RscQueryCluster -Op List).Invoke()
        $clusters1.Nodes.Count | Should -Be 1
        # But Get-RscCluster uses Get-RscPages:
        $clustersG = Get-RscCluster
        $clustersG.Nodes.Count | Should -Be $clusterCount

        # Limit to 2 clusters:
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = 2
        $clusters2 = (New-RscQueryCluster -Op List).Invoke()
        $clusters2.Nodes.Count | Should -Be 2

        # cap First at 1
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = 1
        $clusters21 = (New-RscQueryCluster -Op List -Var @{First = 2 }).Invoke()
        $clusters21.Nodes.Count | Should -Be 1

        # cap First at 2
        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = 2
        $clusters22 = (New-RscQueryCluster -Op List -Var @{First = 2 }).Invoke()
        $clusters22.Nodes.Count | Should -Be 2

        [RubrikSecurityCloud.Config]::ConnectionMaxPageSize = $connectionMaxPageSize

    }
}