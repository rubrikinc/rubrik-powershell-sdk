<#
.SYNOPSIS
Run tests around cluster
#>
BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name 'Cluster' -Fixture {
    It -Name 'Get-RscCluster' -Test {
        Get-RscCluster | Should -Not -BeNullOrEmpty
    }

    Context -Name 'Invoke-RscQueryCluster' {
        It -Name '-List' -Test {
            $count = (Invoke-RscQueryCluster -List).Count
            if ($count -eq 0) {
                Set-ItResult -Skipped -Because "No clusters found"
                return
            }
            $count | Should -BeGreaterThan 0

            # Retrieve the first cluster
            # (and testing variable passing while we're at it)
            (Invoke-RscQueryCluster -List -Var @{first = 1 }).Nodes.Count | Should -Be 1
            (Invoke-RscQueryCluster -List -Var first=1).Nodes.Count | Should -Be 1
            (Invoke-RscQueryCluster -List -Var @{First = 1 }).Nodes.Count | Should -Be 1
            (Invoke-RscQueryCluster -List -Var First=1).Nodes.Count | Should -Be 1

            if ($count -gt 1) {
                (Invoke-RscQueryCluster -List -Var @{first = 2 }).Nodes.Count | Should -Be 2
            }

            # Gql cmdlet:
            (Invoke-RscGqlQueryClusterConnection -Var @{first=1}).Nodes.Count | Should -Be 1

        } 
    }
}
