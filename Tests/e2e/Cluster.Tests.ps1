& "$PSScriptRoot\..\..\Utils\import.ps1"
. "$PSScriptRoot\..\serviceaccount.ps1"

Describe -Name 'Cluster' -Fixture {
    Context -Name 'Connections with service account file' {
        It -Name 'Connect-Rsc' -Test {
            Connect-Rsc | Should -BeLikeExactly "Authentication Status: AUTHORIZED"
        }
        It -Name 'Get-RscCluster' -Test {
            Get-RscCluster | Should -Not -BeNullOrEmpty
        }
        It -Name 'Disconnect-Rsc' -Test {
            Disconnect-Rsc | Should -BeLikeExactly "The Rubrik Security Cloud session has been terminated."
        }
    }
}
