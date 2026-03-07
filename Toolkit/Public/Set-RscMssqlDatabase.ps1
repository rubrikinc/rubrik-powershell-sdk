#Requires -Version 3
function Set-RscMssqlDatabase {
    <#
    .SYNOPSIS
    Configures protection and operational settings for a Microsoft SQL Server database.

    .DESCRIPTION
    Sets SLA Domain assignment, log backup configuration, database-level properties, and pre/post backup scripts on a SQL Server database. You can assign or remove SLA protection, clear an override to inherit from the parent instance or AG, configure log backups, adjust data streams, pause or resume backups, and manage pre/post backup scripts. Use Get-RscMssqlDatabase to obtain the database object.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    The MSSQL database object. Pipe from Get-RscMssqlDatabase.

    .PARAMETER RscCluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

    .PARAMETER DoNotProtect
    Remove SLA protection from the database.

    .PARAMETER ExistingSnapshotRetention
    What to do with existing snapshots when setting to DO NOT PROTECT: EXPIRE_IMMEDIATELY, KEEP_FOREVER, or RETAIN_SNAPSHOTS.

    .PARAMETER ClearExistingProtection
    Revert DO NOT PROTECT and inherit the SLA from the parent instance or Availability Group.

    .PARAMETER ApplySLADomain
    Apply an SLA Domain to this database.

    .PARAMETER RscSlaDomain
    An SLA Domain object to assign. Pipe from Get-RscSla.

    .PARAMETER CopyOnly
    Take copy-only snapshots, which do not interfere with native SQL Server backup chains.

    .PARAMETER EnableLogBackups
    Enable transaction log backups. Omit to disable log backups.

    .PARAMETER UseSLALogConfig
    Use the log backup configuration defined in the SLA Domain instead of custom settings.

    .PARAMETER logBackupFrequencyInSeconds
    Custom log backup frequency in seconds.

    .PARAMETER logRetentionHours
    Custom log backup retention in hours.

    .PARAMETER EnableHostLogRetention
    Enable retention of log backups on the SQL Server host.

    .PARAMETER FollowSystemRetentionConfig
    Use the system-defined retention period for host log retention.

    .PARAMETER HostLogRetentionInSeconds
    Custom host log retention period in seconds.

    .PARAMETER ShouldApplyToExistingSnapshots
    Apply the new SLA policy to existing SLA-based snapshots.

    .PARAMETER ShouldApplyToNonPolicySnapshots
    Apply the new SLA policy to existing snapshots not created by an SLA policy.

    .PARAMETER MaxDataStreams
    Number of parallel data streams for snapshots (1-8, default 2).

    .PARAMETER IsPaused
    Pause or resume backups for this database.

    .PARAMETER ShouldForceFull
    Force the next snapshot to be a full backup instead of Incremental Forever.

    .PARAMETER PreBackupScriptErrorAction
    Action when the pre-backup script fails: SCRIPT_ERROR_ACTION_ABORT or SCRIPT_ERROR_ACTION_CONTINUE.

    .PARAMETER PreBackupScriptPath
    Path to the pre-backup script on the host (must be in C:\Rubrik\Scripts\).

    .PARAMETER PreBackupScriptTimeoutMs
    Timeout in milliseconds for the pre-backup script.

    .PARAMETER PostBackupScriptErrorAction
    Action when the post-backup script fails: SCRIPT_ERROR_ACTION_CONTINUE.

    .PARAMETER PostBackupScriptPath
    Path to the post-backup script on the host (must be in C:\Rubrik\Scripts\).

    .PARAMETER PostBackupScriptTimeoutMs
    Timeout in milliseconds for the post-backup script.

    .PARAMETER RemovePreBackupScript
    Remove the pre-backup script configuration.

    .PARAMETER RemovePostBackupScript
    Remove the post-backup script configuration.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Assign an SLA Domain to a database.

    $db = Get-RscMssqlDatabase -Name "AdventureWorks2019"
    $cluster = Get-RscCluster -Name "MyCluster"
    $sla = Get-RscSla -Name "Gold"
    Set-RscMssqlDatabase -RscMssqlDatabase $db -RscCluster $cluster -ApplySLADomain -RscSlaDomain $sla

    .EXAMPLE
    Configure a pre-backup script on a database.

    $db = Get-RscMssqlDatabase -Name "AdventureWorks2019"
    $cluster = Get-RscCluster -Name "MyCluster"
    Set-RscMssqlDatabase -RscMssqlDatabase $db -RscCluster $cluster -PreBackupScriptErrorAction SCRIPT_ERROR_ACTION_ABORT -PreBackupScriptPath "C:\Rubrik\Scripts\pre.bat" -PreBackupScriptTimeoutMs 30000
    #>

    [CmdletBinding()]
    Param(
        [Parameter(Position = 0, Mandatory = $true)]
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(Mandatory = $true)]
        [RubrikSecurityCloud.Types.Cluster]$RscCluster,

        [Parameter(ParameterSetName = "Do Not Protect", Mandatory = $true)]
        [switch]$DoNotProtect,

        [Parameter(ParameterSetName = "Do Not Protect", Mandatory = $true)]
        [ValidateSet("EXPIRE_IMMEDIATELY", "KEEP_FOREVER", "RETAIN_SNAPSHOTS")]
        [string]$ExistingSnapshotRetention,

        [Parameter(ParameterSetName = "Clear Existing Protection", Mandatory = $true)]
        [switch]$ClearExistingProtection,

        [Parameter(ParameterSetName = "Clear Existing Protection")]
        [switch]$ShouldApplyToExistingSnapshots,

        [Parameter(ParameterSetName = "Clear Existing Protection")]
        [switch]$ShouldApplyToNonPolicySnapshots,

        [Parameter(ParameterSetName = "Apply SLA Domain", Mandatory = $true)]
        [switch]$ApplySLADomain,

        [Parameter(ParameterSetName = "Apply SLA Domain", Mandatory = $true)]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$RscSlaDomain,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [switch]$CopyOnly,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups", Mandatory = $true)]
        [switch]$EnableLogBackups,
        
        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Use SLA Log Config", Mandatory = $true)]
        [switch]$UseSLALogConfig,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Configure Log Backup and Retention", Mandatory = $true)]
        [int]$logBackupFrequencyInSeconds,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Configure Log Backup and Retention", Mandatory = $true)]
        [int]$logRetentionHours,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Enable Host Log Retention", Mandatory = $true)]
        [switch]$EnableHostLogRetention,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Enable Host Log Retention")]
        [Parameter(ParameterSetName = "Follow System Retention Configuration", Mandatory = $true)]
        [switch]$FollowSystemRetentionConfig,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Enable Host Log Retention")]
        [Parameter(ParameterSetName = "Configure Host Log Retention", Mandatory = $true)]
        [int]$HostLogRetentionInSeconds,

        [Parameter(ParameterSetName = "Database Properties")]
        [ValidateRange(1, 8)]
        [int]$MaxDataStreams = 2,

        [Parameter(ParameterSetName = "Database Properties")]
        [switch]$IsPaused,

        [Parameter(ParameterSetName = "Database Properties")]
        [switch]$ShouldForceFull,

        [Parameter(ParameterSetName = "Add Pre-BackupScript", Mandatory = $true)]
        [ValidateSet("SCRIPT_ERROR_ACTION_ABORT", "SCRIPT_ERROR_ACTION_CONTINUE")]
        [String]$PreBackupScriptErrorAction,

        [Parameter(ParameterSetName = "Add Pre-BackupScript", Mandatory = $true)]
        [String]$PreBackupScriptPath,

        [Parameter(ParameterSetName = "Add Pre-BackupScript", Mandatory = $true)]
        [int]$PreBackupScriptTimeoutMs,
        
        [Parameter(ParameterSetName = "Add Post-BackupScript", Mandatory = $true)]
        [ValidateSet("SCRIPT_ERROR_ACTION_CONTINUE")]
        [String]$PostBackupScriptErrorAction,

        [Parameter(ParameterSetName = "Add Post-BackupScript", Mandatory = $true)]
        [String]$PostBackupScriptPath,

        [Parameter(ParameterSetName = "Add Post-BackupScript", Mandatory = $true)]
        [int]$PostBackupScriptTimeoutMs,

        [Parameter(ParameterSetName = "Remove Pre-BackupScript", Mandatory = $true)]
        [Switch]$RemovePreBackupScript,

        [Parameter(ParameterSetName = "Remove Post-BackupScript", Mandatory = $true)]
        [Switch]$RemovePostBackupScript,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    Process {
        Write-Debug "- Running Set-RscMssqlDatabase"
        
        #region Create Query
        switch ($PSCmdlet.ParameterSetName){
            "Do Not Protect" {
                $query = New-RscMutation -Gql assignMssqlSlaDomainPropertiesAsync
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
                $query.Var.input.userNote = ""
                $query.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
                $query.Var.input.updateinfo.ids = @()
                $query.Var.input.updateinfo.ids += $RscMssqlDatabase.id
                switch ($ExistingSnapshotRetention) {
                    "EXPIRE_IMMEDIATELY" {
                        $query.Var.input.updateinfo.ExistingSnapshotRetention = "EXISTING_SNAPSHOT_RETENTION_EXPIRE_IMMEDIATELY"
                    }
                    "KEEP_FOREVER"{
                        $query.Var.input.updateinfo.ExistingSnapshotRetention = "EXISTING_SNAPSHOT_RETENTION_KEEP_FOREVER"
                    }
                    "RETAIN_SNAPSHOTS"{
                        $query.Var.input.updateinfo.ExistingSnapshotRetention = "EXISTING_SNAPSHOT_RETENTION_RETAIN_SNAPSHOTS"
                    }
                }
                $query.Var.input.updateinfo.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
                $query.Var.input.updateinfo.mssqlSlaPatchProperties.configuredSLADomainId = "UNPROTECTED"
                $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaRelatedPropertiesInput
                $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = -1
            }
            "Clear Existing Protection"{
                $query = New-RscMutation -Gql assignMssqlSlaDomainPropertiesAsync
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
                $query.Var.input.userNote = ""
                $query.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
                $query.Var.input.updateinfo.ids = @()
                $query.Var.input.updateinfo.ids += $RscMssqlDatabase.id
                $query.Var.input.updateinfo.shouldApplyToExistingSnapshots = $ShouldApplyToExistingSnapshots
                $query.Var.input.updateinfo.shouldApplyToNonPolicySnapshots = $ShouldApplyToNonPolicySnapshots
                $query.Var.input.updateinfo.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
                $query.Var.input.updateinfo.mssqlSlaPatchProperties.configuredSLADomainId = "INHERIT"
                $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaRelatedPropertiesInput
                $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = -1
            }
            "Apply SLA Domain"{
                $query = New-RscMutation -Gql assignMssqlSlaDomainPropertiesAsync
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
                $query.Var.input.userNote = ""
                $query.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
                $query.Var.input.updateinfo.ids = @()
                $query.Var.input.updateinfo.ids += $RscMssqlDatabase.id
                $query.Var.input.updateinfo.shouldApplyToExistingSnapshots = $ShouldApplyToExistingSnapshots
                $query.Var.input.updateinfo.shouldApplyToNonPolicySnapshots = $ShouldApplyToNonPolicySnapshots
                $query.Var.input.updateinfo.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
                $query.Var.input.updateinfo.mssqlSlaPatchProperties.configuredSLADomainId = $RscSlaDomain.id
                $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaRelatedPropertiesInput

                if ($CopyOnly){
                    $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.copyOnly = $true
                }else {
                    $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.copyOnly = $false
                }
                
                If ($EnableLogBackups){
                    if ($UseSLALogConfig){
                            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla = $true
                    }
                    else{
                        $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla = $false
                        if ($logBackupFrequencyInSeconds){
                            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.logBackupFrequencyInSeconds = $logBackupFrequencyInSeconds
                        }
                        if ($logRetentionHours){
                            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.logRetentionHours = $logRetentionHours
                        }
                    }

                    if ($EnableHostLogRetention){
                        if($FollowSystemRetentionConfig){
                            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = -2
                        }
                        else {
                            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = $HostLogRetentionInSeconds
                        }
                    }
                    else {
                        $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = -1
                    }
                }
            }
            "Database Properties"{
                $query = New-RscMutation -Gql bulkUpdateMssqlDbs
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateMssqlDbsInput
                $query.Var.input.clusterUuid = $RscCluster.Id

                $query.Var.input.dbsUpdateProperties = @()
                $dbsUpdateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateIdInput
                $dbsUpdateProperties.databaseId = $RscMssqlDatabase.Id

                $dbsUpdateProperties.updateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateInput

                if($PSBoundParameters.ContainsKey('MaxDataStreams')){
                    $dbsUpdateProperties.updateProperties.MaxDataStreams = $MaxDataStreams
                }
                if($PSBoundParameters.ContainsKey('shouldForceFull')){
                    $dbsUpdateProperties.updateProperties.shouldForceFull = $shouldForceFull
                }
                if($PSBoundParameters.ContainsKey('IsPaused')){
                    $dbsUpdateProperties.updateProperties.IsPaused = $IsPaused
                }

                $query.Var.input.dbsUpdateProperties += $dbsUpdateProperties
            }
            "Add Pre-BackupScript" {
                $query = New-RscMutation -Gql bulkUpdateMssqlDbs
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateMssqlDbsInput
                $query.Var.input.clusterUuid = $RscCluster.Id

                $query.Var.input.dbsUpdateProperties = @()
                $dbsUpdateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateIdInput
                $dbsUpdateProperties.databaseId = $RscMssqlDatabase.Id

                $dbsUpdateProperties.updateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateInput

                $dbsUpdateProperties.updateProperties.preBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
                $dbsUpdateProperties.updateProperties.preBackupScript.scriptErrorAction = $PreBackupScriptErrorAction
                $dbsUpdateProperties.updateProperties.preBackupScript.scriptPath = $PreBackupScriptPath
                $dbsUpdateProperties.updateProperties.preBackupScript.timeoutMs = $PreBackupScriptTimeoutMs

                $query.Var.input.dbsUpdateProperties += $dbsUpdateProperties
            }
            "Add Post-BackupScript"{
                $query = New-RscMutation -Gql bulkUpdateMssqlDbs
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateMssqlDbsInput
                $query.Var.input.clusterUuid = $RscCluster.Id

                $query.Var.input.dbsUpdateProperties = @()
                $dbsUpdateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateIdInput
                $dbsUpdateProperties.databaseId = $RscMssqlDatabase.Id

                $dbsUpdateProperties.updateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateInput

                $dbsUpdateProperties.updateProperties.postBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
                $dbsUpdateProperties.updateProperties.postBackupScript.scriptErrorAction = $PostBackupScriptErrorAction
                $dbsUpdateProperties.updateProperties.postBackupScript.scriptPath = $PostBackupScriptPath
                $dbsUpdateProperties.updateProperties.postBackupScript.timeoutMs = $PostBackupScriptTimeoutMs

                $query.Var.input.dbsUpdateProperties += $dbsUpdateProperties
            }
            "Remove Pre-BackupScript"{
                $query = New-RscMutation -Gql bulkUpdateMssqlDbs
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateMssqlDbsInput
                $query.Var.input.clusterUuid = $RscCluster.Id

                $query.Var.input.dbsUpdateProperties = @()
                $dbsUpdateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateIdInput
                $dbsUpdateProperties.databaseId = $RscMssqlDatabase.Id

                $dbsUpdateProperties.updateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateInput

                $dbsUpdateProperties.updateProperties.preBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
                $dbsUpdateProperties.updateProperties.preBackupScript.scriptErrorAction = $null
                $dbsUpdateProperties.updateProperties.preBackupScript.scriptPath = $null
                $dbsUpdateProperties.updateProperties.preBackupScript.timeoutMs = $null

                $query.Var.input.dbsUpdateProperties += $dbsUpdateProperties
            }
            "Remove Post-BackupScript"{
                $query = New-RscMutation -Gql bulkUpdateMssqlDbs
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateMssqlDbsInput
                $query.Var.input.clusterUuid = $RscCluster.Id

                $query.Var.input.dbsUpdateProperties = @()
                $dbsUpdateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateIdInput
                $dbsUpdateProperties.databaseId = $RscMssqlDatabase.Id

                $dbsUpdateProperties.updateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateInput

                $dbsUpdateProperties.updateProperties.postBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
                $dbsUpdateProperties.updateProperties.postBackupScript.scriptErrorAction = $null
                $dbsUpdateProperties.updateProperties.postBackupScript.scriptPath = $null
                $dbsUpdateProperties.updateProperties.postBackupScript.timeoutMs = $null

                $query.Var.input.dbsUpdateProperties += $dbsUpdateProperties
            }
            Default {}
        }
        #endregion
        if ( $AsQuery ) { return $query }
        $query.Invoke()
    }
}
