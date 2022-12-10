& "$PSScriptRoot\..\..\Samples\import.ps1"
. "$PSScriptRoot\..\serviceaccount.ps1"

Describe -Name 'Event tests' -Fixture {
    Context -Name 'Event tests' {
        It -Name 'Connect-Rsc -ServiceAccountFile' -Test {
            Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile) | Should -BeLikeExactly "Authentication Status: AUTHORIZED"
        }
        It -Name 'Get-RscEvent' -Test {
            Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile)
            $events = Get-RscEvent -First 1
            $events | Should -Not -BeNullOrEmpty
        }
        It -Name 'Disconnect-Rsc' -Test {
            Disconnect-Rsc | Should -BeLikeExactly "The Rubrik Security Cloud session has been terminated."
        }
    }
}
