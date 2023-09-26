<#
.SYNOPSIS
Run tests around snapshots
#>
BeforeAll {
    . "$PSScriptRoot\..\..\Toolkit\Utils\E2eTestInit.ps1"
}

Describe -Name 'Connect to API' -Fixture {
    It -Name 'Get-RscSnapshot' -Test {
        # TODO: SPARK-225840 fix this
        # $snapshot = Get-RscSnapshot # to do
        # $snapshot | Should -Not -BeNullOrEmpty
    }
}
