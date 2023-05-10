& "$PSScriptRoot\..\..\Utils\import.ps1"
. "$PSScriptRoot\..\serviceaccount.ps1"

Describe -Name 'Event tests' -Fixture {
    Context -Name 'Event tests' {
        It -Name 'Connect-Rsc -ServiceAccountFile' -Test {
            Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile)
        }
        It -Name 'Get-RscEvent' -Test {
            $events = Get-RscEventSeries -First 1
            $events | Should -Not -BeNullOrEmpty
        }
        It -Name 'Disconnect-Rsc' -Test {
            Disconnect-Rsc | Should -BeLikeExactly "The Rubrik Security Cloud session has been terminated."
        }
    }
}
