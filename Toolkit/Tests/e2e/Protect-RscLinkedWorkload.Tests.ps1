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
}

