#Requires -Version 3
function New-RscMssqlLiveMount {
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
        )][datetime]$RestoreTime
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
        $query.Invoke()  
    } 
}
