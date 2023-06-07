<#
.SYNOPSIS
Run tests around field specs for interface fields
#>
BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name 'Event tests' -Fixture {
    It -Name 'Get-RscEvent' -Test {
        $events = Get-RscEventSeries -First 1
        $events | Should -Not -BeNullOrEmpty
    }
}
