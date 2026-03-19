BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        objects = $null
    }
}

Describe -Name 'Protect-RscLinkedWorkload Tests' -Tag 'Public' -Fixture {
    It -Name 'creates a query' -Test {
        $ag1 = Get-RscType -Name MssqlAvailabilityGroup
        $ag2 = Get-RscType -Name MssqlAvailabilityGroup
        $sla = Get-RscType -Name GlobalSlaReply
        $query = Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 -LinkingOperation LINK -Sla $sla -AssignmentType PROTECT_WITH_SLA_ID -AsQuery
        $query | Should -BeOfType [RubrikSecurityCloud.RscQuery]
    }

    It -Name 'accepts -MssqlLogConfigFromSla parameter' -Test {
        $ag1 = Get-RscType -Name MssqlAvailabilityGroup
        $ag2 = Get-RscType -Name MssqlAvailabilityGroup
        $sla = Get-RscType -Name GlobalSlaReply
        # AsQuery returns before the follow-up mutation fires, so this validates the parameter is accepted
        $query = Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 -LinkingOperation LINK -Sla $sla -AssignmentType PROTECT_WITH_SLA_ID -MssqlLogConfigFromSla -AsQuery
        $query | Should -BeOfType [RubrikSecurityCloud.RscQuery]
    }

    It -Name '-MssqlLogConfigFromSla requires -Sla' -Test {
        $ag1 = Get-RscType -Name MssqlAvailabilityGroup
        $ag2 = Get-RscType -Name MssqlAvailabilityGroup
        { Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 -LinkingOperation LINK -AssignmentType PROTECT_WITH_SLA_ID -MssqlLogConfigFromSla } | Should -Throw "*requires -Sla*"
    }
}

