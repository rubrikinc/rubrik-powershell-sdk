#Requires -Version 3
function New-RscMssqlSnapshot {
    <#
    .SYNOPSIS
    Starts an On Demand Snapshot of a MSSQL Database

    .DESCRIPTION
    Starts an On Demand Snapshot of a MSSQL Database

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER ForceFullSnapshot
    Instead of taking an Incremental Forever snapshot, which the default, this will force a new Full snapshot. 

    Incremental Forever snapshots are the equivalent of a SQL Server Full database backup. Do not use this parameter
    if your intent is to reset a broken log chain. That can be achieved by taking a snapshot without this parameter. 

    .PARAMETER RscSlaDomain
    THis will be the ID of the SLA Domain that will manage the retention of the snapshot

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
        )][RubrikSecurityCloud.Types.GlobalSlaReply]$RscSlaDomain
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
        $query.Var.input.config.baseOnDemandSnapshotConfig.slaId = $RscSlaDomain.Id
        #endregion
        
        $result = $query.Invoke()
        $result
    } 
}
