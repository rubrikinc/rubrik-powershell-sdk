#Requires -Version 3
function New-RscMssqlLogShippingSecondary{
    <#
    .SYNOPSIS
    Adds a new log Shipping secondary to a database

    .DESCRIPTION
    Adds a new log Shipping secondary to a database

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER RscCluster
    Database object returned from Get-RscCluster

    .PARAMETER TargetMssqlInstance
    SQL Server Instance Object returned from Get-RscMssqlInstance

    .PARAMETER TargetDatabaseName
    Any name you want to call your database when it is recovered onto the target instance

    .PARAMETER TargetDataPath
    Single path that all data files will be placed into 

    .PARAMETER TargeLogPath
    Single path that all log files will be placed into

    .PARAMETER TargetFilePaths
    Object can be built manually like the below example, or by using Get-RscMssqlDatabaseFiles. 

    .PARAMETER MaxDataStreams
    This controls the number of streams used for the restore. By default, Rubrik will use 2 streams. This cannot exceed a value of 8. 

    In general, the default value of 2 performs best. However in some cases, increasing the value can provide better performance of the restore. Do not change this value in a
    production setting without running some tests in a non-production environment. 

    .PARAMETER DisconnectStandbyUsers
    Automatically disconnect users when restoring backups
    .PARAMETER State
    State of Log Shipping Secondaary. Can be either RESTORING or STANDBY

    .PARAMETER AutomaticReseed
    Automatically reseed the log shipping configuration when the primary transaction log chain breaks
    
    #>

    [CmdletBinding()]
    Param(
        [Parameter(            
            Mandatory = $true, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $false
        )][RubrikSecurityCloud.Types.Cluster]$RscCluster,

        [Parameter(
            Mandatory = $true
        )][RubrikSecurityCloud.Types.MssqlInstance]$TargetMssqlInstance, 

        [Parameter(
            Mandatory = $true
        )][String]$TargetDatabaseName,

        [Parameter(
            ParameterSetName = "Simple Method",
            Mandatory = $false
        )][String]$TargetDataPath,

        [Parameter(
            ParameterSetName = "Simple Method",
            Mandatory = $false
        )][String]$TargeLogPath,

        [Parameter(
            ParameterSetName = "Advanced Method",
            Mandatory = $false
        )][PSCustomObject]$TargetFilePaths,

        [ValidateRange(1, 8)]
        [Parameter(
            Mandatory = $false
        )][int]$MaxDataStreams = 2,

        [Parameter(
            Mandatory = $false
        )][Switch]$DisconnectStandbyUsers,

        [Parameter(Mandatory = $true)]
        [ValidateSet("RESTORING", "STANDBY")]
        [String]$State,

        [Parameter(
            Mandatory = $false
        )][Switch]$AutomaticReseed

    )
    
    Process {
        Write-Debug "- Running New-RscMssqlLogShippingSecondary"
        
        #region Create Query         
        $query = New-RscMutationMssql -Op CreateLogShippingConfiguration
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.CreateMssqlLogShippingConfigurationInput
        $query.Var.input.Id = $RscMssqlDatabase.Id
        $query.Var.input.clusterUuid = $RscCluster.Id
        
        $query.Var.input.Config = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingCreateConfigV2Input
        if ($AutomaticReseed){
            $query.Var.input.Config.makeupReseedLimit = 1
        }
        else {
            $query.Var.input.Config.makeupReseedLimit = 0
        }
        
        $query.Var.input.Config.mssqlLogShippingCreateConfig = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingCreateConfigInput
        If (![string]::IsNullOrEmpty($maxDataStreams)){$query.Var.input.Config.mssqlLogShippingCreateConfig.maxDataStreams = $maxDataStreams}
        
        # Simple Method
        If (![string]::IsNullOrEmpty($TargetDataPath) -and ![string]::IsNullOrEmpty($TargeLogPath)){
            $query.Var.input.Config.mssqlLogShippingCreateConfig.targetDataFilePath = $TargetDataPath
            $query.Var.input.Config.mssqlLogShippingCreateConfig.targetLogFilePath = $TargeLogPath
        }
        # Advanced Method
        If (![string]::IsNullOrEmpty($TargetFilePaths)){
            $query.Var.input.Config.mssqlLogShippingCreateConfig.targetFilePaths = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbFileExportPathInput 
            $query.Var.input.Config.mssqlLogShippingCreateConfig.targetFilePaths = $TargetFilePaths
        }

        $query.Var.input.Config.mssqlLogShippingCreateConfig.targetDatabaseName = $TargetDatabaseName
        $query.Var.input.Config.mssqlLogShippingCreateConfig.targetInstanceId = $TargetMssqlInstance.Id
        $query.Var.input.Config.mssqlLogShippingCreateConfig.mssqlLogShippingTargetStateOptions = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetStateOptionsInput
        
        if ($DisconnectStandbyUsers){
            $query.Var.input.Config.mssqlLogShippingCreateConfig.mssqlLogShippingTargetStateOptions.shouldDisconnectStandbyUsers = $true
        }else {
            $query.Var.input.Config.mssqlLogShippingCreateConfig.mssqlLogShippingTargetStateOptions.shouldDisconnectStandbyUsers = $false
        }
        switch ($State) {
            "Restoring" { 
                $query.Var.input.Config.mssqlLogShippingCreateConfig.mssqlLogShippingTargetStateOptions.state = "MSSQL_LOG_SHIPPING_OK_STATE_RESTORING"
             }
             "StandBy" {
                $query.Var.input.Config.mssqlLogShippingCreateConfig.mssqlLogShippingTargetStateOptions.state = "MSSQL_LOG_SHIPPING_OK_STATE_STANDBY"
             }
        }        
        #endregion

        $query.Invoke()
        
    } 
}
