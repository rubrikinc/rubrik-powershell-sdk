#Requires -Version 3
function New-RscMssqlLiveMount {
    <#
    .SYNOPSIS
    Creates a live mount of a Microsoft SQL Server database.

    .DESCRIPTION
    Mounts a point-in-time copy of a SQL Server database onto a target instance as a fully operational database. Live mounts let you access data for testing, reporting, or validation without affecting the production database. The mounted database is backed by Rubrik storage and can be removed when no longer needed with Remove-RscMssqlLiveMount.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    The MSSQL database object to mount. Pipe from Get-RscMssqlDatabase.

    .PARAMETER MountedDatabaseName
    The name for the mounted database on the target instance.

    .PARAMETER TargetMssqlInstance
    The destination SQL Server instance. Pipe from Get-RscMssqlInstance.

    .PARAMETER RecoveryDateTime
    Use Get-RscMssqlDatabaseRecoveryPoint to get a fully formatted date and time for the recovery point
    
    .PARAMETER TargetMssqlInstance
    SQL Server Instance Object returned from Get-RscMssqlInstance
    
    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Returns the list of database files based on the latest recovery point
    
    New-RscMssqlLiveMount -RscMssqlDatabase $RscMssqlDatabase -TargetMssqlInstance $RscTargetMssqlInstance -RecoveryDateTime $RecoveryDateTime

The point-in-time to mount, in UTC. Use Get-RscMssqlDatabaseRecoveryPoint to obtain a properly formatted value.

    .EXAMPLE
    Live mount a database to a target instance at a specific recovery point.

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    $inst = Get-RscMssqlInstance -HostName rp-sql1.rubrik-demo.com -clusterId "124d26df-c31f-49a3-a8c3-77b10c9470c2"
    $recovery = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $db -Latest
    New-RscMssqlLiveMount -RscMssqlDatabase $db -MountedDatabaseName "AW2019_Mount" -TargetMssqlInstance $inst -RecoveryDateTime $recovery

    .EXAMPLE
    Mount using a specific point-in-time value.

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    $inst = Get-RscMssqlInstance -HostName rp-sql1.rubrik-demo.com -clusterId "124d26df-c31f-49a3-a8c3-77b10c9470c2"
    New-RscMssqlLiveMount -RscMssqlDatabase $db -MountedDatabaseName "AW2019_Test" -TargetMssqlInstance $inst -RecoveryDateTime "2024-01-15T10:00:00.000Z"
    #>

    [CmdletBinding(
    )]
    Param(
        [Parameter(
            Mandatory = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $true
        )][String]$MountedDatabaseName,

        [Parameter(
            Mandatory = $true
        )][RubrikSecurityCloud.Types.MssqlInstance]$TargetMssqlInstance, 
       
        [Parameter(
            Mandatory = $true
        )][datetime]$RecoveryDateTime,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        Write-Debug "- Running New-RscMssqlLiveMount"
        #region Create Query         
        $query = New-RscMutation -Gql createMssqlLiveMount 
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.CreateMssqlLiveMountInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        $query.Var.input.config = New-Object RubrikSecurityCloud.Types.MountMssqlDbConfigInput
        $query.Var.input.config.mountedDatabaseName = "$($MountedDatabaseName)"

        $query.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
        $query.Var.input.config.recoveryPoint.date = $RecoveryDateTime
        $query.Var.input.config.targetInstanceId = "$($TargetMssqlInstance.Id)"

        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
