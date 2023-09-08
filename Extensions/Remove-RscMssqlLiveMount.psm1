#Requires -Version 3
function Remove-RscMssqlLiveMount {
    <#
    .SYNOPSIS
    ___ Add synopsis here ___

    .DESCRIPTION
    ___ Add description here ___

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabaseLiveMount]$MssqlLiveMount, 

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $false
        )]
        [Switch]$Force 

    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }
        Write-Host "Remove-RscMssqlLiveMount: $inputProfile"
        
        $mssqlInputs = Invoke-RscMutateMssql -DeleteLiveMount -GetInput
        $mssqlInputs.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.DeleteMssqlLiveMountInput

        $mssqlInputs.Var.input.id = "$($MssqlLiveMount.Fid)"
        $mssqlInputs.Var.input.force = $force

        Invoke-RscMutateMssql -DeleteLiveMount -Var $mssqlInputs.var 

        # ___ Example ___
        #
        # Retrieve input objects:
        #
        # $in = (___INVOKE_CMDLET___ -InputProfile $inputProfile -GetInput)
        #
        # Customize input:
        #
        # $in.Var.clusterUuid = $Id
        #
        # Invoke GraphQL operation:
        #
        # $result = ___INVOKE_CMDLET___ -Input $in
        #
        # Filter results:
        #
        # if ( $PSCmdlet.ParameterSetName -eq "List" ) {
        #   $result = $result.Nodes
        # }
        #
        # Filter out null values:
        # $result | Remove-NullProperties
        #
    } 
}
