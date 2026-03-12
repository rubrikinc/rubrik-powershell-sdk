#Requires -Version 3
function Resume-RscSla {
    <#
    .SYNOPSIS
    Resumes a suspended SLA Domain on one or more Rubrik clusters.

    .DESCRIPTION
    Reactivates snapshot scheduling for an SLA Domain that was previously suspended with Suspend-RscSla. You must specify which clusters to resume the SLA on, since an SLA can be suspended independently per cluster. Pipe an SLA object from Get-RscSla or provide the SLA ID directly.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER SlaId
    The RSC object ID of the SLA Domain to resume.

    .PARAMETER ClusterUuids
    One or more Rubrik cluster UUIDs on which to resume the SLA Domain.

    .PARAMETER GlobalSla
    An SLA Domain object to resume. Pipe from Get-RscSla.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

Return the query object instead of executing it.

    .EXAMPLE
    Resume an SLA on specific clusters by SLA ID.

    Resume-RscSla -SlaId "abc-123" -ClusterUuids @("cluster-uuid-1", "cluster-uuid-2")

    .EXAMPLE
    Pipe an SLA object and resume it on a cluster.

    Get-RscSla -Name "Gold" | Resume-RscSla -ClusterUuids @("9c930153-2a3c-4b7d-8603-48145315e71f")
    #>

    [CmdletBinding(DefaultParameterSetName = "GlobalSlaInput")]
    Param(
        [Parameter(
            ParameterSetName = "ResumeSLAInput",
            Mandatory = $true,
            ValueFromPipelineByPropertyName = $true,
            HelpMessage = "The SLA ID which needs to be resumed"
        )]
        [String]$SlaId,

        [Parameter(
            ParameterSetName = "ResumeSLAInput",
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
                Global SLA which needs to be resumed"
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
            "pauseSla" = $false
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
