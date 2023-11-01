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
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$MountedDatabaseName,

        [Parameter(
            ParameterSetName = "TargetMssqlInstanceId",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$TargetMssqlInstanceId,

        [Parameter(
            ParameterSetName = "TargetMssqlInstance",
            Mandatory = $false, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.PhysicalHost]$TargetMssqlInstance, 
        
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Latest,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$LastFull,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][datetime]$RestoreTime,

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
        $query = New-RscMutationMssql -Op CreateLiveMount 
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.CreateMssqlLiveMountInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        $query.Var.input.config = New-Object RubrikSecurityCloud.Types.MountMssqlDbConfigInput
        $query.Var.input.config.mountedDatabaseName = "$($MountedDatabaseName)"

        if($PSBoundParameters.ContainsKey('Latest')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -Latest
        }

        if($PSBoundParameters.ContainsKey('LastFull')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -LastFull
        }

        if($PSBoundParameters.ContainsKey('RestoreTime')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -RestoreTime $RestoreTime
        }
        $query.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
        $query.Var.input.config.recoveryPoint.date = $RecoveryPoint

        switch ( $PSCmdlet.ParameterSetName){
            "TargetMssqlInstanceId" {
                $query.Var.input.config.targetInstanceId = "$($TargetMssqlInstanceId)"
            }
            "TargetMssqlInstance" {
                $query.Var.input.config.targetInstanceId = "$($TargetMssqlInstance.PhysicalChildConnection.Nodes.Id)"
            }
        }
        #endregion

        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }
        $result
    } 
}
