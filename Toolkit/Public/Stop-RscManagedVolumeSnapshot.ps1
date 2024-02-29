#Requires -Version 3
function Stop-RscManagedVolumeSnapshot {
    <#
    .SYNOPSIS
    Stops a Snapshot of a Persistent Mount Managed Volume

    .DESCRIPTION
    Stop a Snapshot of a Persistent Mount Managed Volume. This will make the managed volume read only. Rubrik will then
    process the snapshot for future recovery operations. 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscManagedVolume
    Managed Volume Object as retrieved from Get-RscManagedVolume

    .PARAMETER RscSlaDomain
    SLA Domain Object as retrieved from Get-RscSlaDomain
    
    .EXAMPLE
    $RscManagedVolume = Get-RscManagedVolume -Name rp-mysql-01
    Stop-RscManagedVolumeSnapshot -RscManagedVolume $RscManagedVolume -SlaDomainId $RscManagedVolume.EffectiveSlaDomain.Id
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
        )][RubrikSecurityCloud.Types.GlobalSlaReply]$RscSlaDomain
    )
    
    Process {
        Write-Debug "-Running Stop-RscManagedVolumeSnapshot"
        
        #region Create Query
        $query = New-RscMutationManagedVolume -Operation EndSnapshot
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.EndManagedVolumeSnapshotInput
        $query.Var.input.id = $RscManagedVolume.Id
        $query.Var.input.params = New-Object -TypeName RubrikSecurityCloud.Types.EndSnapshotManagedVolumeRequestInput
        $query.Var.input.params.isAsync = $true
        $query.Var.input.params.retentionConfig = New-Object -TypeName RubrikSecurityCloud.Types.BaseOnDemandSnapshotConfigInput
        $query.Var.input.params.retentionConfig.slaId = $RscSlaDomain.Id
        #endregion

        $result = $query.Invoke()
        $result
    } 
}
