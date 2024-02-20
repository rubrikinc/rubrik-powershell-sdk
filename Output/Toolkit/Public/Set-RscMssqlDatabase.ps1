#Requires -Version 3
function Set-RscMssqlDatabase {
    <#
    .SYNOPSIS
    Sets properties of a database in RSC

    .DESCRIPTION
    Sets properties of a database in RSC. Properties include SLA Domains and their properties, Pre and Post scripts, 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER RscCluster
    RscCluster object retrieved via Get-RscCluster

    .PARAMETER DoNotProtect
    Sets the protection property on the database to DO NOT PROTECT

    .PARAMETER ExistingSnapshotRetention
    Defines what should happen to existing snapshots when you set the database to DO NOT PROTECT

    .PARAMETER ClearExistingProtection
    Reverts the DO NOT PROTECT and tells the database to inherit from the next highest level. Instance or AG. 

    .PARAMETER RscSlaDomain
    This will be the ID of the SLA Domain that will manage the retention of the snapshot

    .PARAMETER CopyOnly
    When assigning an SLA, this will instruct RSC to take copy only snapshots of the database

    .PARAMETER EnableLogBackups
    Including this parameter will enable log backups. If this parameter is omitted, then log backups wull be disabled

    .PARAMETER UseSLALogConfig
    If you enable log backups, this switch states to use the log configuration defined in the SLA

    .PARAMETER logBackupFrequencyInSeconds
    If you do not include the UseSLALogConfig parameter and you Enable Log Backups, you must include this parameter to define the log backup freqency
    .PARAMETER logRetentionHours
    If you do not include the UseSLALogConfig parameter and you Enable Log Backups, you must include this parameter to define the log backup retention

    .PARAMETER EnableHostLogRetention
    Including this parameter will enable Host Log Retention. This feature will not be widely used as it is only for special use cases. 

    .PARAMETER FollowSystemRetentionConfig
    Uses the system retention value for when to remove the log backup from the host when Host Log Retention is enabled

    .PARAMETER HostLogRetentionInSeconds
    User defined retention value for when to remove the log backup from the host when Host Log Retention is enabled

    .PARAMETER ShouldApplyToExistingSnapshots
    When setting the above SLA related properties, this defines what should happen to existing snapshots that are SLA Domain based

    .PARAMETER ShouldApplyToNonPolicySnapshots
    When setting the above SLA related properties, this defines what should happen to existing snapshots that are NOT SLA Domain based

    .PARAMETER MaxDataStreams
    Is a performance parameter. Increasing may increase performance. The default is 2, and the max number of data streams is 8
    A stream relates to a database file. 

    .PARAMETER IsPaused
    Determines if backups should be paused or resumed

    .PARAMETER ShouldForceFull
    Determins if the next snapshot is a FULL instead of the normal incremental forever. There is almost no reason to use feature. 

    .PARAMETER PreBackupScriptErrorAction
    Determines what should happen when the script fails. Can be 1 of 2 actions. 
    SCRIPT_ERROR_ACTION_ABORT or SCRIPT_ERROR_ACTION_CONTINUE

    .PARAMETER PreBackupScriptPath
    Path to a Windows batch script file. Script must reside in C:\Rubrik\Scripts\ as per the UI
    
    .PARAMETER PreBackupScriptTimeoutMs
    Determines how long RSC should wait before timing out and failing the script. 

    .PARAMETER PostBackupScriptErrorAction
    Determines what should happen when the script fails. Can be 1 of 2 actions. 
    SCRIPT_ERROR_ACTION_ABORT or SCRIPT_ERROR_ACTION_CONTINUE

    .PARAMETER PostBackupScriptPath
    Path to a Windows batch script file. Script must reside in C:\Rubrik\Scripts\ as per the UI
    
    .PARAMETER PostBackupScriptTimeoutMs
    Determines how long RSC should wait before timing out and failing the script. 
    
    .PARAMETER RemovePreBackupScript
    Removes the Pre Script values

    .PARAMETER RemovePostBackupScript
    Removes the Post Script values

    .EXAMPLE
    Set-RscMssqlDatabase -RscMssqlDatabase $RscMssqlDatabase -RscCluster $RscCluster -RscSlaDomain $RscSlaDomain
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Position = 0,
            Mandatory = $true, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Position = 1,
            Mandatory = $true
        )][RubrikSecurityCloud.Types.Cluster]$RscCluster,

        [Parameter(
            Position = 2,
            ParameterSetName = "Do Not Protect",
            Mandatory = $false
        )][switch]$DoNotProtect,

        [Parameter(
            Position = 3,
            ParameterSetName = "Do Not Protect",
            Mandatory = $true
        )]
        [ValidateSet("EXPIRE_IMMEDIATELY", "KEEP_FOREVER", "RETAIN_SNAPSHOTS")]
        [string]$ExistingSnapshotRetention,

        [Parameter(
            Position = 2,
            ParameterSetName = "Clear Existing Protection",
            Mandatory = $false
        )][switch]$ClearExistingProtection,

        [Parameter(
            Position = 2,
            ParameterSetName = "Apply SLA Domain",
            Mandatory = $false
        )][RubrikSecurityCloud.Types.GlobalSlaReply]$RscSlaDomain,

        [Parameter(
            ParameterSetName = "Apply SLA Domain",
            Position = 3
        )][switch]$CopyOnly,

        [Parameter(
            ParameterSetName = "Apply SLA Domain",
            Position = 4
        )]
        [Parameter(ParameterSetName = "Log Backups", Mandatory = $false)]
        [switch]$EnableLogBackups,
        
        [Parameter(ParameterSetName = "Apply SLA Domain", Position = 5)]
        [Parameter(ParameterSetName = "Log Backups", Mandatory = $false)]
        [Parameter(ParameterSetName = "Use SLA Log Config")]
        [switch]$UseSLALogConfig,

        [Parameter(ParameterSetName = "Apply SLA Domain", Position = 6)]
        [Parameter(ParameterSetName = "Log Backups", Mandatory = $false)]
        [Parameter(ParameterSetName = "Configure Log Backup and Retention")]
        [int]$logBackupFrequencyInSeconds,

        [Parameter(ParameterSetName = "Apply SLA Domain", Position = 7)]
        [Parameter(ParameterSetName = "Log Backups", Mandatory = $false)]
        [Parameter(ParameterSetName = "Configure Log Backup and Retention")]
        [int]$logRetentionHours,

        [Parameter(ParameterSetName = "Apply SLA Domain", Position = 8)]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Enable Host Log Retention")]
        [Parameter(Mandatory = $false)]
        [switch]$EnableHostLogRetention,

        [Parameter(ParameterSetName = "Apply SLA Domain", Position = 9)]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Enable Host Log Retention")]
        [Parameter(ParameterSetName = "Follow System Retention Configuration")]
        [Parameter(Mandatory = $false)]
        [switch]$FollowSystemRetentionConfig,

        [Parameter(ParameterSetName = "Apply SLA Domain", Position = 11)]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Enable Host Log Retention")]
        [Parameter(ParameterSetName = "Configure Host Log Retention")]
        [Parameter(Mandatory = $false)]
        [int]$HostLogRetentionInSeconds,

        [Parameter(ParameterSetName = "Apply SLA Domain", Position = 12)]
        [Parameter(
            ParameterSetName = "Clear Existing Protection",
            Mandatory = $false
        )][switch]$ShouldApplyToExistingSnapshots,
        
        [Parameter(ParameterSetName = "Apply SLA Domain", Position = 13)]
        [Parameter(
            ParameterSetName = "Clear Existing Protection",
            Mandatory = $false
        )][switch]$ShouldApplyToNonPolicySnapshots,

        [ValidateRange(1, 8)]
        [Parameter(
            ParameterSetName = "Database Properties",
            Mandatory = $false,
            Position = 3
        )][int]$MaxDataStreams = 2,

        [Parameter(
            ParameterSetName = "Database Properties",
            Mandatory = $false,
            Position = 4
        )][switch]$IsPaused,

        [Parameter(
            ParameterSetName = "Database Properties",
            Mandatory = $false,
            Position = 5
        )][switch]$ShouldForceFull,

        [Parameter(ParameterSetName = "Add Pre-BackupScript", Mandatory = $false)]
        [ValidateSet("SCRIPT_ERROR_ACTION_ABORT", "SCRIPT_ERROR_ACTION_CONTINUE")]
        [String]$PreBackupScriptErrorAction,

        [Parameter(ParameterSetName = "Add Pre-BackupScript", Mandatory = $false)]
        [String]$PreBackupScriptPath,

        [Parameter(ParameterSetName = "Add Pre-BackupScript", Mandatory = $false)]
        [int]$PreBackupScriptTimeoutMs,
        
        [Parameter(ParameterSetName = "Add Post-BackupScript", Mandatory = $false)]
        [ValidateSet("SCRIPT_ERROR_ACTION_CONTINUE")]
        [String]$PostBackupScriptErrorAction,

        [Parameter(ParameterSetName = "Add Post-BackupScript", Mandatory = $false)]
        [String]$PostBackupScriptPath,

        [Parameter(ParameterSetName = "Add Post-BackupScript", Mandatory = $false)]
        [int]$PostBackupScriptTimeoutMs,

        [Parameter(ParameterSetName = "Remove Pre-BackupScript", Mandatory = $false)]
        [Switch]$RemovePreBackupScript,

        [Parameter(ParameterSetName = "Remove Post-BackupScript", Mandatory = $false)]
        [Switch]$RemovePostBackupScript
    )
    
    Process {
        Write-Debug "- Running Set-RscMssqlDatabase"
        
        #region Create Query
        switch ($PSCmdlet.ParameterSetName){
            "Do Not Protect" {
                $query = New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync
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
                $query = New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync
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
                $query = New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync
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
                $query = New-RscMutation -GqlMutation bulkUpdateMssqlDbs
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateMssqlDbsInput
                $query.Var.input.clusterUuid = $RscCluster.Id

                $query.Var.input.dbsUpdateProperties = @()
                $dbsUpdateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateIdInput
                $dbsUpdateProperties.databaseId = $RscMssqlDatabase.Id

                $dbsUpdateProperties.updateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateInput

                if ($MaxDataStreams){
                    $dbsUpdateProperties.updateProperties.MaxDataStreams = $MaxDataStreams
                }
                if ($shouldForceFull){
                    $dbsUpdateProperties.updateProperties.shouldForceFull = $true
                }else {
                    $dbsUpdateProperties.updateProperties.shouldForceFull = $false
                }
                if ($IsPaused){
                    $dbsUpdateProperties.updateProperties.IsPaused = $true
                }
                else {
                    $dbsUpdateProperties.updateProperties.IsPaused = $false
                }
                $query.Var.input.dbsUpdateProperties += $dbsUpdateProperties
            }
            "Add Pre-BackupScript" {
                $query = New-RscMutation -GqlMutation bulkUpdateMssqlDbs
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
                $query = New-RscMutation -GqlMutation bulkUpdateMssqlDbs
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
                $query = New-RscMutation -GqlMutation bulkUpdateMssqlDbs
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
                $query = New-RscMutation -GqlMutation bulkUpdateMssqlDbs
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
        $query.Invoke()
    } 
}
