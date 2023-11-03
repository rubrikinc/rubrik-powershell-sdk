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

    .PARAMETER AsQuery
    Instead of running the command, the query and variables used for the query will be returned. 
    
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
        [RubrikSecurityCloud.Types.ManagedVolume]$RscManagedVolume,

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
        $query = New-RscMutationManagedVolume -Operation BeginSnapshot
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BeginManagedVolumeSnapshotInput
        $query.Var.input.id = $RscManagedVolume.Id
        $query.Var.input.config = New-Object -TypeName RubrikSecurityCloud.Types.BeginSnapshotManagedVolumeRequestInput
        $query.Var.input.config.isAsync = $true
        
        
        #endregion

        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }

        $result
    } 
}
