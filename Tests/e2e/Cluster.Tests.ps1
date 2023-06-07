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
}
