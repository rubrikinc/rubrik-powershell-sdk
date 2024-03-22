#Requires -Version 3
function Remove-RscSla {
    <#
    .SYNOPSIS
    Remove RSC SLA (service level agreement).

    .DESCRIPTION
    The Remove-RscSLA cmdlet is used for deleting a global
    SLA (service level agreement).
    The -Id parameter is the SLA domain Id.
    The -UserNote parameter is optional and is used in the audit
    message for the delete action on RSC.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Id
    The Id of the SLA which needs to be deleted.

    .PARAMETER GlobalSla
    The Global Sla which should be removed.

    .PARAMETER UserNote
    The user note to be used for auditing the deletion of SLA on
    RSC.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Delete an SLA with the given SLA id and usernote
    Remove-RscSLA -SlaId xxx-xxx -UserNote "somestring"

    .EXAMPLE
    Use the powershell pipe to remove the Global SLA.
    $result = Get-RscSla -Name 'Sample SLA Domain'
    $result | Remove-RscSla
    #>

    [CmdletBinding(DefaultParameterSetName = "GlobalSlaInput")]
    Param(
        [Parameter(
            ParameterSetName = "RemoveSLAInput",
            Mandatory = $true,
            ValueFromPipelineByPropertyName = $true,
            HelpMessage = "The SLA ID which needs to be deleted"
        )]
        [String]$SlaId,

        [Parameter(
            ParameterSetName = "RemoveSLAInput",
            Mandatory = $false,
            ValueFromPipelineByPropertyName = $false,
            HelpMessage = "The user note for auditing the delete action"
        )]
        [String]$UserNote,

        [Parameter(
            ParameterSetName = "GlobalSlaInput",
            Mandatory = $true,
            ValueFromPipeline = $true,
            HelpMessage = "The object representing the 
                Global SLA which needs to be removed"
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
        $query = (New-RscMutationSla -op "DeleteGlobal")

        if ($PsCmdlet.ParameterSetName -eq "GlobalSlaInput") {
            $SlaId = $GlobalSla.ID
        }

        $query.Var.id = $SlaId
        if( $UserNote ) {
            $query.Var.userNote = $UserNote
        }

        # Skip invoking the query, return the query object
        if ( $AsQuery ) {
            return $query
        }

        # Invoke the query
        $response = Invoke-Rsc -Query $query

        $response
    }
}
