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

    .PARAMETER SlaDomainId
    THis will be the ID of the SLA Domain that will manage the retention of the snapshot
    
    .PARAMETER AsQuery
    Instead of running the command, the query and variables used for the query will be returned. 

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
            ValueFromPipeline = $true
        )]
        [string]$SlaDomainId,

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$AsQuery
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        Write-Host "Start-RscManagedVolumeSnapshot field profile: $fieldProfile"
        
        #region Create Query
        $query = New-RscMutationManagedVolume -Operation EndSnapshot
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.EndManagedVolumeSnapshotInput
        $query.Var.input.id = $RscManagedVolume.Id
        $query.Var.input.params = New-Object -TypeName RubrikSecurityCloud.Types.EndSnapshotManagedVolumeRequestInput
        $query.Var.input.params.isAsync = $true
        $query.Var.input.params.retentionConfig = New-Object -TypeName RubrikSecurityCloud.Types.BaseOnDemandSnapshotConfigInput
        $query.Var.input.params.retentionConfig.slaId = $SlaDomainId
        #endregion

        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }
        $result
    } 
}
