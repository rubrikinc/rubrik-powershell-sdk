& "$PSScriptRoot\..\..\Samples\import.ps1"
. "$PSScriptRoot\..\serviceaccount.ps1"

Describe -Name 'Connect to API' -Fixture {
    Context -Name 'Connections with service account file' {
        It -Name 'Connect-Rsc -ServiceAccountFile' -Test {
            Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile) | Should -BeLikeExactly "Authentication Status: AUTHORIZED"
        }
        It -Name 'Get-RscSnapshot' -Test {
            Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile)
            $snapshot = Get-RscSnapshot # to do
            $snapshot | Should -Not -BeNullOrEmpty
        }
        It -Name 'Disconnect-Rsc' -Test {
            Disconnect-Rsc | Should -BeLikeExactly "The Rubrik Security Cloud session has been terminated."
        }
    }
}
