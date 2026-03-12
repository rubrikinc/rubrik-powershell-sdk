#Requires -Version 3
function Stop-RscManagedVolumeSnapshot {
    <#
    .SYNOPSIS
    Ends a snapshot of a persistent-mount Managed Volume.

    .DESCRIPTION
    Closes the write window on a persistent-mount Managed Volume that was opened with Start-RscManagedVolumeSnapshot. The volume returns to read-only mode and Rubrik processes the snapshot for retention and recovery. You must supply an SLA Domain object to control the retention of the resulting snapshot.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscManagedVolume
    The Managed Volume object. Pipe from Get-RscManagedVolume.

    .PARAMETER RscSlaDomain
    SLA Domain Object as retrieved from Get-RscSlaDomain
    
    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

An SLA Domain object for snapshot retention. Pipe from Get-RscSla.

    .EXAMPLE
    End a snapshot using the volume's effective SLA Domain.

    $mv = Get-RscManagedVolume -Name "rp-mysql-01"
    $sla = Get-RscSla -Name "Gold"
    Stop-RscManagedVolumeSnapshot -RscManagedVolume $mv -RscSlaDomain $sla

    .EXAMPLE
    Pipe the Managed Volume and specify the SLA.

    Get-RscManagedVolume -Name "rp-mysql-01" | Stop-RscManagedVolumeSnapshot -RscSlaDomain (Get-RscSla -Name "Gold")
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.ManagedVolume]$RscManagedVolume,

        [Parameter(
            Mandatory = $true,
            ValueFromPipeline = $false
        )][RubrikSecurityCloud.Types.GlobalSlaReply]$RscSlaDomain,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        Write-Debug "-Running Stop-RscManagedVolumeSnapshot"
        
        #region Create Query
        $query = New-RscMutation -Gql endManagedVolumeSnapshot -RemoveField RscSnapshotId
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.EndManagedVolumeSnapshotInput
        $query.Var.input.id = $RscManagedVolume.Id
        $query.Var.input.params = New-Object -TypeName RubrikSecurityCloud.Types.EndSnapshotManagedVolumeRequestInput
        $query.Var.input.params.isAsync = $true
        $query.Var.input.params.retentionConfig = New-Object -TypeName RubrikSecurityCloud.Types.BaseOnDemandSnapshotConfigInput
        $query.Var.input.params.retentionConfig.slaId = $RscSlaDomain.Id
        #endregion

        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
