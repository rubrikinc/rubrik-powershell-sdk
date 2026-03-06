<#
.SYNOPSIS
E2e tests for Get-RscFilesetTemplate (requires live RSC connection).
Parameter validation tests are in Tests/unit/Get-RscFilesetTemplate.Tests.ps1.
#>
BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}

Describe -Name 'Get-RscFilesetTemplate Tests' -Tag 'Public' -Fixture {
    Context -Name 'Live query' {
        It -Name 'Fields work as expected' -Test {
            $fields = Get-RscType -Name FilesetTemplate -InitialProperties @("Name","OsType")
            $results = Get-RscFilesetTemplate -OsType Windows -Field $fields -First 1
            if ($results.Count -eq 0) {
                Set-ItResult -Skipped -Because "No fileset templates found"
                return
            }
            $results[0].Id | Should -BeNullOrEmpty
            $results[0].Name | Should -Not -BeNullOrEmpty
            $results[0].OsType | Should -Not -BeNullOrEmpty
            $results[0].ObjectType | Should -BeNullOrEmpty
        }
    }
}
