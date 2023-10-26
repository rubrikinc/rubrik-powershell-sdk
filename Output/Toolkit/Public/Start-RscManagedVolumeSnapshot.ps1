#Requires -Version 3
function Start-RscManagedVolumeSnapshot {
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
            Mandatory = $true, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.ManagedVolume]$RscManagedVolume

        # [Parameter(
        #     Mandatory = $true, 
        #     ValueFromPipeline = $true
        # )]
        # [RubrikSecurityCloud.Types.ManagedVolume]$RscManagedVolume,
        
        #  Common parameter to all parameter sets:
        # [Parameter(
        #     Mandatory = $false, 
        #     ValueFromPipelineByPropertyName = $true
        # )]
        # [Switch]$Detail
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        Write-Host "Start-RscManagedVolumeSnapshot field profile: $fieldProfile"
        
        #region Create Query
        $query = New-RscMutationManagedVolume -Operation BeginSnapshot
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BeginManagedVolumeSnapshotInput
        $query.Var.input.id = $RscManagedVolume.Id
        $query.Var.input.config = New-Object -TypeName RubrikSecurityCloud.Types.BeginSnapshotManagedVolumeRequestInput
        $query.Var.input.config.isAsync = $true
        
        $query.invoke()
    } 
}
