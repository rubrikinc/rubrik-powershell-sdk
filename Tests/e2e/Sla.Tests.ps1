<#
.SYNOPSIS
Run tests around SLAs

.DESCRIPTION
This file is the companion to the Sla.Tests.ps1 file in the unit folder.

This file tests if the query runs correctly.
It does not test the integrity of the query.
See Tests/unit/Sla.Tests.ps1 for testing the integrity of the query.

#>
BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}

Describe -Name 'SLAs' -Fixture {
    It -Name 'SLA Domains' -Test {

        # ----------------------------------------------------------
        #
        #            1. Retrieve the list of SLAs
        #
        # (list of 1 but still a list, not a single object)
        # ----------------------------------------------------------

        $q1 = New-RscQuery -GqlQuery slaDomains -Var @{first = 1 }

        $r1 = $q1 | Invoke-Rsc
        $totalSlaCount = $r1.count
        $retrievedSlaCount = $r1.nodes.count
        $totalSlaCount | Should -BeGreaterOrEqual $retreivedSlaCount
        if ($retrievedSlaCount -ne 1) {
            Set-ItResult -Skipped -Because "This test needs at least 1 SLA to run"
            return
        }
        # The returned SLA object should be a SlaDomain-implementing object
        $implementingTypes = Get-RscHelp -Interface SlaDomain -ImplementingTypes
        $r1.Nodes | ForEach-Object {
            $implementingTypes | Should -Contain $_.GetType().Name
        }

        # ----------------------------------------------------------
        #
        #               2. Retrieve a single SLA
        #
        # ----------------------------------------------------------

        $slaId = $r1.nodes[0].id
        $q2 = New-RscQuery -GqlQuery slaDomain -Var @{id = $slaId }
        $r2 = $q2 | Invoke-Rsc
        $r2.Count | Should -Be 1
        $implementingTypes | Should -Contain $r2.GetType().Name
        $r2.id | Should -Be $slaId
    }
}