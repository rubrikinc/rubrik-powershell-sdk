<#
.SYNOPSIS
Run tests around snapshots
#>
BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}

Describe -Name 'Snapshot Tests' -Fixture {
    It -Name 'Get-RscSnapshot' -Test {
        # TODO: SPARK-225840 fix this
        # $snapshot = Get-RscSnapshot # to do
        # $snapshot | Should -Not -BeNullOrEmpty
    }
}
