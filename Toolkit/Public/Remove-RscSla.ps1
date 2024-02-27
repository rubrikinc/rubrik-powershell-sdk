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

    .PARAMETER UserNote
    The user note to be used for auditing the deletion of SLA on
    RSC.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Delete an SLA with the given SLA id and usernote
    Remove-RscSLA -SlaId xxx-xxx -UserNote "somestring"
    #>

    [CmdletBinding(DefaultParameterSetName = "SuspendSLAInput")]
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
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )]
        [Switch]$AsQuery
    )

    Process {
        # Re-use existing connection, or create a new one (stop in case of error):
        Connect-Rsc -ErrorAction Stop | Out-Null

        $query = (New-RscMutationSla -op "DeleteGlobal")
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
