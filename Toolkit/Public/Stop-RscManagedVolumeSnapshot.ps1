#Requires -Version 3
function Stop-RscManagedVolumeSnapshot {
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
        [RubrikSecurityCloud.Types.ManagedVolume]$RscManagedVolume,

        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true
        )]
        [string]$SlaDomainId
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
        $query.invoke()
    } 
}
