<#
.SYNOPSIS
E2e tests for Get-RscHost (requires live RSC connection).
Parameter validation tests are in Tests/unit/Get-RscHost.Tests.ps1.
#>
BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}

Describe -Name 'Get-RscHost Tests' -Tag 'Public' -Fixture {
    Context -Name 'Live query' {
        It -Name 'Fields work as expected' -Test {
            $fields = Get-RscType -Name PhysicalHost -InitialProperties @("Name","OsType")
            $results = Get-RscHost -OsType Windows -Field $fields -First 1
            if ($results.Count -eq 0) {
                Set-ItResult -Skipped -Because "No hosts found"
                return
            }
            $results[0].Id | Should -BeNullOrEmpty
            $results[0].Name | Should -Not -BeNullOrEmpty
            $results[0].OsType | Should -Not -BeNullOrEmpty
            $results[0].ObjectType | Should -BeNullOrEmpty
        }
    }
}
