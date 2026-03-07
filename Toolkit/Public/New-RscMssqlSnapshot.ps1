#Requires -Version 3
function New-RscMssqlSnapshot {
    <#
    .SYNOPSIS
    Takes an on-demand snapshot of a Microsoft SQL Server database.

    .DESCRIPTION
    Triggers an immediate snapshot of the specified SQL Server database using the given SLA Domain for retention. By default, an Incremental Forever snapshot is taken, which is equivalent to a SQL Server full backup. Use -ForceFullSnapshot only when you need to force a new base full; a normal snapshot already resets a broken log chain.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER RscMssqlDatabase
    The MSSQL database object to snapshot. Pipe from Get-RscMssqlDatabase.

    .PARAMETER ForceFullSnapshot
    Force a new full snapshot instead of the default Incremental Forever snapshot. Rarely needed; a standard snapshot already resets a broken log chain.

    .PARAMETER RscSlaDomain
    An SLA Domain object to use for snapshot retention. Pipe from Get-RscSla.

    .EXAMPLE
    Take an on-demand snapshot of a database.

    $sla = Get-RscSla -Name "Gold"
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlSnapshot -RscMssqlDatabase $db -RscSlaDomain $sla

    .EXAMPLE
    Force a full snapshot.

    $sla = Get-RscSla -Name "Gold"
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlSnapshot -RscMssqlDatabase $db -RscSlaDomain $sla -ForceFullSnapshot $true
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
        )][RubrikSecurityCloud.Types.GlobalSlaReply]$RscSlaDomain,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        #region Create Query
        $query = New-RscMutation -Gql createOnDemandMssqlBackup
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.CreateOnDemandMssqlBackupInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        
        $query.Var.input.config = New-Object RubrikSecurityCloud.Types.MssqlBackupJobConfigInput
        $query.Var.input.config.forceFullSnapshot = $ForceFullSnapshot

        $query.Var.input.config.baseOnDemandSnapshotConfig = New-Object RubrikSecurityCloud.Types.BaseOnDemandSnapshotConfigInput
        $query.Var.input.config.baseOnDemandSnapshotConfig.slaId = $RscSlaDomain.Id
        #endregion
        
        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
