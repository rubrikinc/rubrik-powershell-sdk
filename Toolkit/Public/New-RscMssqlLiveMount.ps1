#Requires -Version 3
function New-RscMssqlLiveMount {
    <#
    .SYNOPSIS
    Creates a Live Mount of a MSSQL Database

    .DESCRIPTION
    Creates a Live Mount of a MSSQL Database

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER MountedDatabaseName
    Name of the database that was Live Mounted
    
    .PARAMETER TargetMssqlInstanceId
    Used to return a specific SQL Server Instance based on the Id assigned inside of Rubrik

    .PARAMETER AsQuery
    Instead of running the command, the query and variables used for the query will be returned. 

    .PARAMETER Latest
    Uses the latest recovery point date and time that Rubrik has for a database

    .PARAMETER LastFull
    Uses the last snapshot date and time that Rubrik has for a database

    .PARAMETER RestoreTime
    Restore time can in 1 of 3 formats
        - Relative to the last 24 hours: 02:00 will recover a database to 2AM on today's date. 
        - Local time: 2023-11-02 08:00:000
        - UTC: 2023-11-02 08:00:000Z
    All values will be converted into UTC and used as the recovery point.

    .PARAMETER TargetMssqlInstance
    SQL Server Instance Object returned from Get-RscMssqlInstance
    
    .EXAMPLE
    Returns the list of database files based on the latest recovery point
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    $RscTargetMssqlInstance = Get-RscMssqlInstance -HostName rp-sql1.rubrik-demo.cm -clusterId "124d26df-c31f-49a3-a8c3-77b10c9470c2"
    New-RscMssqlLiveMount -RscMssqlDatabase $RscMssqlDatabase -TargetMssqlInstance $RscTargetMssqlInstance -Latest

    .EXAMPLE
    Returns the list of database files based on the last snapshot taken
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    $RscTargetMssqlInstance = Get-RscMssqlInstance -HostName rp-sql1.rubrik-demo.cm -clusterId "124d26df-c31f-49a3-a8c3-77b10c9470c2"
    New-RscMssqlLiveMount -RscMssqlDatabase $RscMssqlDatabase -TargetMssqlInstance $RscTargetMssqlInstance -Lastfull

    .EXAMPLE
    Returns the list of database files based on a specific point in time. 
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    $RscTargetMssqlInstance = Get-RscMssqlInstance -HostName rp-sql1.rubrik-demo.cm -clusterId "124d26df-c31f-49a3-a8c3-77b10c9470c2"
    New-RscMssqlLiveMount -RscMssqlDatabase $RscMssqlDatabase -TargetMssqlInstance $RscTargetMssqlInstance -RestoreTime "2023-10-27 08:37:00.000Z"
    #>

    [CmdletBinding(
    )]
    Param(
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $false
        )][String]$MountedDatabaseName,

        [Parameter(
            Mandatory = $false
        )][RubrikSecurityCloud.Types.PhysicalHost]$TargetMssqlInstance, 
       
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][datetime]$RecoveryDateTime
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        #region Create Query         
        $query = New-RscMutationMssql -Op CreateLiveMount 
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.CreateMssqlLiveMountInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        $query.Var.input.config = New-Object RubrikSecurityCloud.Types.MountMssqlDbConfigInput
        $query.Var.input.config.mountedDatabaseName = "$($MountedDatabaseName)"

        # if($PSBoundParameters.ContainsKey('Latest')) {
        #     $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -Latest
        # }

        # if($PSBoundParameters.ContainsKey('LastFull')) {
        #     $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -LastFull
        # }

        # if($PSBoundParameters.ContainsKey('RestoreTime')) {
        #     $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -RestoreTime $RestoreTime
        # }
        $query.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
        $query.Var.input.config.recoveryPoint.date = $RecoveryDateTime
        $query.Var.input.config.targetInstanceId = "$($TargetMssqlInstance.PhysicalChildConnection.Nodes.Id)"

        # switch ( $PSCmdlet.ParameterSetName){
        #     "TargetMssqlInstanceId" {
        #         $query.Var.input.config.targetInstanceId = "$($TargetMssqlInstanceId)"
        #     }
        #     "TargetMssqlInstance" {
                
        #     }
        # }
        #endregion

        $result = $query.Invoke()
        $result
    } 
}
