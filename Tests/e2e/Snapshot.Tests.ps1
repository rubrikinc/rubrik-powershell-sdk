BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"
    . "$PSScriptRoot\..\serviceaccount.ps1"
}

Describe -Name 'Connect to API' -Fixture {
    BeforeAll {
        Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile)
    }

    It -Name 'Get-RscSnapshot' -Test {
        # TODO: SPARK-225840 fix this
        # $snapshot = Get-RscSnapshot # to do
        # $snapshot | Should -Not -BeNullOrEmpty
    }
}
