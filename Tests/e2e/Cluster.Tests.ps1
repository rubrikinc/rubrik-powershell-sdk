<#
.SYNOPSIS
Run tests around cluster
#>
BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}

Describe -Name 'Cluster Tests' -Fixture {
    Context -Name 'New-RscQueryCluster' {
        It -Name '-Op List' -Test {
            $r = (New-RscQueryCluster -Op List -RemoveField Nodes).Invoke()
            # Object's 'Count' property is hidden by the 'Count' method
            # so we can't do `$r.Count`
            $count = $r | Select-Object -ExpandProperty Count
            if ($count -eq 0) {
                Set-ItResult -Skipped -Because "No clusters found"
                return
            }
            $count | Should -BeGreaterThan 0

            Get-RscCluster -Count | Should -Be $count

            # Retrieve the first cluster
            # (and testing variable passing while we're at it)
            (New-RscQueryCluster -Op List -Var first=1).Invoke().Nodes.Count | Should -Be 1

            if ($count -gt 1) {
                (New-RscQueryCluster -Op List -Var @{first = 2 }).Invoke().Nodes.Count | Should -Be 2
            }

        } 
    }
}
