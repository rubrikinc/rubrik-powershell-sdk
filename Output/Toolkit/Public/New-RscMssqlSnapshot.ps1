#Requires -Version 3
function New-RscMssqlSnapshot {
    <#
    .SYNOPSIS
    Starts an On Demand Snapshot of a MSSQL Database

    .DESCRIPTION
    Starts an On Demand Snapshot of a MSSQL Database

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Starts an On Demand Snapshot of a MSSQL Database with an SLA Domain ID
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlSnapshot -RscMssqlDatabase $RscMssqlDatabase -SLADomain "124d26df-c31f-49a3-a8c3-77b10c9470c2"
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
        )][string]$SLADomain,

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$AsQuery
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
        
        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }
        $result
    } 
}
