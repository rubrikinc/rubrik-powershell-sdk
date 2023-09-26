<#
.SYNOPSIS
Run tests around field specs for interface fields
#>
BeforeAll {
    . "$PSScriptRoot\..\..\Toolkit\Utils\E2eTestInit.ps1"
}

Describe -Name 'Event tests' -Fixture {
    It -Name 'Get-RscEvent' -Test {
        $events = Get-RscEventSeries -First 1
        $events | Should -Not -BeNullOrEmpty
    }
}
