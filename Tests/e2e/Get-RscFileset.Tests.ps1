<#
.SYNOPSIS
E2e tests for Get-RscFileset (requires live RSC connection).
Parameter validation tests are in Tests/unit/Get-RscFileset.Tests.ps1.
#>
BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}

Describe -Name 'Get-RscFileset Tests' -Tag 'Public' -Fixture {
    Context -Name "Call with HostId" {
        It -Name "First 3 Windows Hosts from Get-RscHost" -Test {
            $hosts = Get-RscHost -OsType Windows -First 3
            if ($hosts.Count -eq 0) {
                Set-ItResult -Skipped -Because "No Windows hosts found"
                return
            }
            $hosts | ForEach-Object {
                $hostId = $_.Id
                Get-RscFileset -HostId $hostId
            }
        }
    }
}
