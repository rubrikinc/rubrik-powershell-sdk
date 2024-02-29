#Requires -Version 3
function Start-RscManagedVolumeSnapshot {
    <#
    .SYNOPSIS
    Start a Snapshot of a Persistent Mount Managed Volume

    .DESCRIPTION
    Start a Snapshot of a Persistent Mount Managed Volume. This will make the managed volume writable. 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscManagedVolume
    Managed Volume Object as retrieved from Get-RscManagedVolume
   
    .EXAMPLE
    $RscManagedVolume = Get-RscManagedVolume -Name rp-mysql-01
    Start-RscManagedVolumeSnapshot -RscManagedVolume $RscManagedVolume
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.ManagedVolume]$RscManagedVolume
    )
    
    Process {
        Write-Debug "-Running Start-RscManagedVolumeSnapshot"      
        #region Create Query
        $query = New-RscMutationManagedVolume -Operation BeginSnapshot
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BeginManagedVolumeSnapshotInput
        $query.Var.input.id = $RscManagedVolume.Id
        $query.Var.input.config = New-Object -TypeName RubrikSecurityCloud.Types.BeginSnapshotManagedVolumeRequestInput
        $query.Var.input.config.isAsync = $true

        #endregion
        $result = $query.Invoke()
        $result
    } 
}
