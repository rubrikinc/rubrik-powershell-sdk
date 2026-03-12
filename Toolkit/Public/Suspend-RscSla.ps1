#Requires -Version 3
function Suspend-RscSla {
    <#
    .SYNOPSIS
    Suspends an SLA Domain on one or more Rubrik clusters.

    .DESCRIPTION
    Pauses snapshot scheduling for an SLA Domain on the specified clusters. While suspended, no new snapshots are taken for workloads governed by this SLA on those clusters. Existing snapshots and their retention are not affected. Use Resume-RscSla to reactivate the SLA. Pipe an SLA object from Get-RscSla or provide the SLA ID directly.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER SlaId
    The RSC object ID of the SLA Domain to suspend.

    .PARAMETER ClusterUuids
    One or more Rubrik cluster UUIDs on which to suspend the SLA Domain.

    .PARAMETER GlobalSla
    An SLA Domain object to suspend. Pipe from Get-RscSla.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

Return the query object instead of executing it.

    .EXAMPLE
    Suspend an SLA on specific clusters by SLA ID.

    Suspend-RscSla -SlaId "abc-123" -ClusterUuids @("cluster-uuid-1", "cluster-uuid-2")

    .EXAMPLE
    Pipe an SLA object and suspend it on a cluster.

    Get-RscSla -Name "Gold" | Suspend-RscSla -ClusterUuids @("9c930153-2a3c-4b7d-8603-48145315e71f")
    #>

    [CmdletBinding(DefaultParameterSetName = "GlobalSlaInput")]
    Param(
        [Parameter(
            ParameterSetName = "SuspendSLAInput",
            Mandatory = $true,
            ValueFromPipelineByPropertyName = $true,
            HelpMessage = "The ID of the SLA which should be suspended"
        )]
        [String]$SlaId,

        [Parameter(
            ParameterSetName = "SuspendSLAInput",
            Mandatory = $true,
            ValueFromPipelineByPropertyName = $true,
            HelpMessage = "The list of cluster UUIDs on which the SLA is applied"
        )]
        [Parameter(
            ParameterSetName = "GlobalSlaInput",
            Mandatory = $true,
            HelpMessage = "The list of cluster UUIDs on which the SLA is applied"
        )]
        [String[]]$ClusterUuids,

        [Parameter(
            ParameterSetName = "GlobalSlaInput",
            Mandatory = $true,
            ValueFromPipeline = $true,
            HelpMessage = "The object representing the 
                Global SLA which needs to be suspended"
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$GlobalSla,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )]
        [Switch]$AsQuery
    )

    Process {
        $query = (New-RscMutation -Gql pauseSla)

        if ($PsCmdlet.ParameterSetName -eq "GlobalSlaInput") {
            $SlaId = $GlobalSla.ID
        }

        $pauseSlaInput = Get-RscType -Name "PauseSlaInput" -InitialValues @{
            "slaId" = $SlaId
            "pauseSla" = $true
            "clusterUuids" = [System.Collections.Generic.List[string]]$ClusterUuids
        }
        $query.Var.input = $pauseSlaInput

        # Skip invoking the query, return the query object
        if ( $AsQuery ) {
            return $query
        }

        # Invoke the query
        $response = Invoke-Rsc -Query $query

        $response
    }
}
