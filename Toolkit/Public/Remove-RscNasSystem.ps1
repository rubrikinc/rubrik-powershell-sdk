#Requires -Version 3
function Remove-RscNasSystem {
    <#
    .SYNOPSIS
    Delete a NAS system by specifying the NAS system ID.

    .DESCRIPTION
    This cmdlet is used to delete a NAS system from Rubrik Security Cloud.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Id
    The Rubrik UUID of the NAS system object.

    .PARAMETER NasSystem
    The object representing the NAS system to be deleted.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Remove-RscNasSystem "b951f770-4519-5820-a451-5b2ff4a50f25"

    .EXAMPLE
    Use the powershell pipe to delete the NAS system.
    $nasSystem = Get-RscNasSystem -Id "b951f770-4519-5820-a451-5b2ff4a50f25"
    $nasSystem | Remove-RscNasSystem
    #>

    [CmdletBinding()]
    Param(
        # The ID of the NAS system that needs to be deleted.
        [Parameter(Mandatory = $true, Position = 0, ParameterSetName = "Id")]
        [ValidateNotNullOrEmpty()]
        [String]$Id,

        # The object representing the NAS system to be deleted.
        [Parameter(
            Mandatory = $true,
            ValueFromPipeline = $true,
            ParameterSetName = "NasSystem"
        )]
        [RubrikSecurityCloud.Types.NasSystem]$NasSystem,

        # Should Cmdlet return the query object instead of running it.
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )]
        [Switch]$AsQuery
    )

    Process {
        $mutation = New-RscMutationNas -Operation DeleteNasSystem `
            -AddField Progress, Error

        $mutation.Var.Input =
            New-Object -TypeName RubrikSecurityCloud.Types.DeleteNasSystemInput
        $mutation.Var.Input.Id = $Id

        if ($PsCmdlet.ParameterSetName -eq "NasSystem") {
            $mutation.Var.Input.Id = $NasSystem.Id
        }

        if ($AsQuery) {
            return $mutation
        }

        $result = Invoke-Rsc -Query $mutation
        $result
    }
}