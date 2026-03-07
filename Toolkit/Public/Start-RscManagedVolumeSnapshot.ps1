#Requires -Version 3
function Start-RscManagedVolumeSnapshot {
    <#
    .SYNOPSIS
    Begins a snapshot of a persistent-mount Managed Volume.

    .DESCRIPTION
    Opens a write window on a persistent-mount Managed Volume so that an application can write data to it. While the snapshot is in progress, the volume is writable. Call Stop-RscManagedVolumeSnapshot when the write operation is complete to finalize the snapshot and return the volume to read-only mode.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscManagedVolume
    Managed Volume Object as retrieved from Get-RscManagedVolume
   
    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

The Managed Volume object. Pipe from Get-RscManagedVolume.

    .EXAMPLE
    Start a snapshot to open a write window on a Managed Volume.

    $mv = Get-RscManagedVolume -Name "rp-mysql-01"
    Start-RscManagedVolumeSnapshot -RscManagedVolume $mv

    .EXAMPLE
    Pipe the Managed Volume object directly.

    Get-RscManagedVolume -Name "rp-mysql-01" | Start-RscManagedVolumeSnapshot
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.ManagedVolume]$RscManagedVolume,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )]
        [Switch]$AsQuery
    )
    
    Process {
        Write-Debug "-Running Start-RscManagedVolumeSnapshot"      
        #region Create Query
        $query = New-RscMutation -Gql beginManagedVolumeSnapshot -RemoveField RscSnapshotId
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BeginManagedVolumeSnapshotInput
        $query.Var.input.id = $RscManagedVolume.Id
        $query.Var.input.config = New-Object -TypeName RubrikSecurityCloud.Types.BeginSnapshotManagedVolumeRequestInput
        $query.Var.input.config.isAsync = $true

        #endregion
        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
