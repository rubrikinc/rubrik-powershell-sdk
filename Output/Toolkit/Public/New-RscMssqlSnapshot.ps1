#Requires -Version 3
function New-RscMssqlSnapshot {
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
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,
        
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][bool]$ForceFullSnapshot,
        
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $false
        )][string]$SLADomain
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        #region Create Query
        $query = New-RscMutationMssql -Op CreateOnDemandBackup
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.CreateOnDemandMssqlBackupInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        
        $query.Var.input.config = New-Object RubrikSecurityCloud.Types.MssqlBackupJobConfigInput
        $query.Var.input.config.forceFullSnapshot = $ForceFullSnapshot

        $query.Var.input.config.baseOnDemandSnapshotConfig = New-Object RubrikSecurityCloud.Types.BaseOnDemandSnapshotConfigInput
        $query.Var.input.config.baseOnDemandSnapshotConfig.slaId = $SLADomain
        #endregion
        
        $query.Invoke()
    } 
}
