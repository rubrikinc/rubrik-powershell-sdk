#Requires -Version 3
function New-RscMssqlLogShippingSecondary{
    <#
    .SYNOPSIS
    Creates a new log shipping secondary for a Microsoft SQL Server database.

    .DESCRIPTION
    Configures a log shipping secondary database on a target SQL Server instance. Log shipping continuously applies transaction log backups from the primary database to the secondary, keeping it synchronized. You can choose between RESTORING mode (no read access) and STANDBY mode (read-only access). Two file-placement methods are available: a simple mode with a single data and log path, or an advanced mode with per-file path control.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    The primary MSSQL database object. Pipe from Get-RscMssqlDatabase.

    .PARAMETER RscCluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

    .PARAMETER TargetMssqlInstance
    The destination SQL Server instance for the secondary database. Pipe from Get-RscMssqlInstance.

    .PARAMETER TargetDatabaseName
    The name for the secondary database on the target instance.

    .PARAMETER TargetDataPath
    A single directory path where all data files will be placed (simple mode).

    .PARAMETER TargeLogPath
    A single directory path where all log files will be placed (simple mode).

    .PARAMETER TargetFilePaths
    An array of objects specifying per-file paths (advanced mode). Build manually or use Get-RscMssqlDatabaseFiles.

    .PARAMETER MaxDataStreams
    Number of parallel data streams for the restore (1-8, default 2). Test in a non-production environment before increasing.

    .PARAMETER DisconnectStandbyUsers
    Automatically disconnect users from the secondary database when applying log backups.

    .PARAMETER State
    The state of the log shipping secondary: RESTORING (no read access) or STANDBY (read-only access).

    .PARAMETER AutomaticReseed
    Automatically reseed the log shipping configuration when the primary transaction log chain breaks
    

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

Automatically reseed the log shipping configuration when the primary transaction log chain breaks.

    .EXAMPLE
    Create a log shipping secondary in STANDBY mode with simple file paths.

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    $cluster = Get-RscCluster -Name "MyCluster"
    $inst = Get-RscMssqlInstance -HostName rp-sql2.rubrik-demo.com -clusterId $cluster.Id
    New-RscMssqlLogShippingSecondary -RscMssqlDatabase $db -RscCluster $cluster -TargetMssqlInstance $inst -TargetDatabaseName "AW2019_Secondary" -TargetDataPath "D:\SQLData" -TargeLogPath "L:\SQLLogs" -State STANDBY -DisconnectStandbyUsers

    .EXAMPLE
    Create a log shipping secondary in RESTORING mode with automatic reseed enabled.

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    $cluster = Get-RscCluster -Name "MyCluster"
    $inst = Get-RscMssqlInstance -HostName rp-sql2.rubrik-demo.com -clusterId $cluster.Id
    New-RscMssqlLogShippingSecondary -RscMssqlDatabase $db -RscCluster $cluster -TargetMssqlInstance $inst -TargetDatabaseName "AW2019_DR" -TargetDataPath "D:\SQLData" -TargeLogPath "L:\SQLLogs" -State RESTORING -AutomaticReseed
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
        )][Switch]$AutomaticReseed,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        Write-Debug "- Running New-RscMssqlLogShippingSecondary"
        
        #region Create Query         
        $query = New-RscMutation -Gql createMssqlLogShippingConfiguration
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

        if ( $AsQuery ) { return $query }
        $query.Invoke()

    }
}
