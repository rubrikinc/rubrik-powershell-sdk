#Requires -Version 3
function Resume-RscSla {
    <#
    .SYNOPSIS
    Resume RSC SLA (service level agreement).
    
    .DESCRIPTION
    The Resume-RscSla cmdlet is used to resume a given
    SLA (service level agreement) on one or more clusters
    on which this SLA is applicable.
    The -SlaId parameter is used for identifying the SLA, 
    this parameter is required.
    The -ClusterUuids specifies a list of cluster Uuids on 
    which this SLA needs to be resumed.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER SlaId
    The Id of the SLA which needs to be resumed.

    .PARAMETER ClusterUuids
    The cluster IDs on which the SLA needs to be resumed.

    .PARAMETER GlobalSla
    The Global Sla which should be resumed.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Resume an SLA on two clusters on which it is applied.
    Resume-RscSLA -SlaId xxx-xxx -ClusterUuids @('yyy-yyy', 'zzz-zzz')

    .EXAMPLE
    Use the powershell pipe to resume the Global SLA.
    $result = Get-RscSla -Name 'Sample SLA Domain'
    $result | Resume-RscSla -ClusterUuids @('9c930153-2a3c-4b7d-8603-48145315e71f')
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
        $query = (New-RscMutationSla -op "Pause")

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
