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

    .PARAMETER RecoveryDateTime
    Use Get-RscMssqlDatabaseRecoveryPoint to get a fully formatted date and time for the recovery point
    
    .PARAMETER TargetMssqlInstance
    SQL Server Instance Object returned from Get-RscMssqlInstance
    
    .EXAMPLE
    Returns the list of database files based on the latest recovery point
    
    New-RscMssqlLiveMount -RscMssqlDatabase $RscMssqlDatabase -TargetMssqlInstance $RscTargetMssqlInstance -RecoveryDateTime $RecoveryDateTime

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
        )][datetime]$RecoveryDateTime
    )
    
    Process {
        Write-Debug "- Running New-RscMssqlLiveMount"
        #region Create Query         
        $query = New-RscMutationMssql -Op CreateLiveMount 
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.CreateMssqlLiveMountInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        $query.Var.input.config = New-Object RubrikSecurityCloud.Types.MountMssqlDbConfigInput
        $query.Var.input.config.mountedDatabaseName = "$($MountedDatabaseName)"

        $query.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
        $query.Var.input.config.recoveryPoint.date = $RecoveryDateTime
        $query.Var.input.config.targetInstanceId = "$($TargetMssqlInstance.Id)"

        $result = $query.Invoke()
        $result
    } 
}
