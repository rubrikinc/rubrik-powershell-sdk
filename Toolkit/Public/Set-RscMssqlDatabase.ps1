#Requires -Version 3
function Set-RscMssqlDatabase {
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

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $true
        )][RubrikSecurityCloud.Types.Cluster]$RscCluster,

        [Parameter(
            ParameterSetName = "Do Not Protect",
            Mandatory = $false
        )][switch]$DoNotProtect,

        [Parameter(ParameterSetName = "Do Not Protect",Mandatory = $true)]
        [ValidateSet("EXPIRE_IMMEDIATELY", "KEEP_FOREVER", "RETAIN_SNAPSHOTS")]
        [string]$ExistingSnapshotRetention,

        [Parameter(
            ParameterSetName = "Clear Existing Protection",
            Mandatory = $false
        )][switch]$ClearExistingProtection,

        [Parameter(
            ParameterSetName = "Apply SLA Domain",
            Mandatory = $false
        )][RubrikSecurityCloud.Types.GlobalSlaReply]$RscSlaDomain,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [switch]$CopyOnly,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups", Mandatory = $false)]
        [switch]$EnableLogBackups,
        
        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups", Mandatory = $false)]
        [Parameter(ParameterSetName = "Use SLA Log Config")]
        [switch]$UseSLALogConfig,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups", Mandatory = $false)]
        [Parameter(ParameterSetName = "Configure Log Backup and Retention")]
        [int]$logBackupFrequencyInSeconds,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups", Mandatory = $false)]
        [Parameter(ParameterSetName = "Configure Log Backup and Retention")]
        [int]$logRetentionHours,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Enable Host Log Retention")]
        [Parameter(Mandatory = $false)]
        [switch]$EnableHostLogRetention,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Enable Host Log Retention")]
        [Parameter(ParameterSetName = "Follow System Retention Configuration")]
        [Parameter(Mandatory = $false)]
        [switch]$FollowSystemRetentionConfig,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(ParameterSetName = "Log Backups")]
        [Parameter(ParameterSetName = "Enable Host Log Retention")]
        [Parameter(ParameterSetName = "Configure Host Log Retention")]
        [Parameter(Mandatory = $false)]
        [int]$HostLogRetention,

        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(
            ParameterSetName = "Clear Existing Protection",
            Mandatory = $false
        )][switch]$ShouldApplyToExistingSnapshots,
        
        [Parameter(ParameterSetName = "Apply SLA Domain")]
        [Parameter(
            ParameterSetName = "Clear Existing Protection",
            Mandatory = $false
        )][switch]$ShouldApplyToNonPolicySnapshots







        # [Parameter(Mandatory = $false)]
        # [bool]$IsPaused,

        # [ValidateRange(1, 8)]
        # [Parameter(
        #     Mandatory = $false
        # )][int]$MaxDataStreams = 2,

        # [Parameter(Mandatory = $false)]
        # [bool]$ShouldForceFull,

        # [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        # [ValidateSet("SCRIPT_ERROR_ACTION_ABORT", "SCRIPT_ERROR_ACTION_CONTINUE")]
        # [String]$PreBackupScriptErrorAction,

        # [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        # [String]$PreBackupScriptPath,

        # [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        # [int]$PreBackupScriptTimeoutMs,
        
        # [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        # [ValidateSet("SCRIPT_ERROR_ACTION_ABORT", "SCRIPT_ERROR_ACTION_CONTINUE")]
        # [String]$PostBackupScriptErrorAction,

        # [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        # [String]$PostBackupScriptPath,

        # [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        # [int]$PostBackupScriptTimeoutMs,

        # [Parameter(Mandatory = $false, ParameterSetName = "Remove Pre-BackupScript")]
        # [Switch]$RemovePreBackupScript,

        # [Parameter(Mandatory = $false, ParameterSetName = "Remove Post-BackupScript")]
        # [Switch]$RemovePostBackupScript,


        
        # [Parameter(Mandatory = $false)]
        # [bool]$HasLogConfigFromSla,

     

        # [Parameter(Mandatory = $false)]
        # [int]$LogBackupFrequencyInSeconds,


    )
    
    Process {
        Write-Debug "- Running Set-RscMssqlDatabase"
        
        #region Create Query
        # $query = New-RscMutationMssql -Operation BulkUpdateDbs

        # $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateMssqlDbsInput
        # $query.Var.input.clusterUuid = $RscCluster.Id

        # $query.Var.input.dbsUpdateProperties = @()
        # $dbsUpdateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateIdInput
        # $dbsUpdateProperties.databaseId = $RscMssqlDatabase.Id

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
                        if(FollowSystemRetentionConfig){

                        }
                        else {
                            <# Action when all if and elseif conditions are false #>
                        }

                    }
                    else {
                        $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = -1
                    }
                }
            }
            Default {}
        }
        
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlNonSlaProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlNonSlaPropertiesInput
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlNonSlaProperties.copyOnly = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlNonSlaProperties.logBackupFrequencyinSeconds = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlNonSlaProperties.logRetentionHours = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlSlaPatchProperties.configuredSLADomainId = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlSlaPatchProperties.mssqlSlaRelatedProperties = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlSlaPatchProperties.useConfiguredDefaultLogRetention = 
        
        # $dbsUpdateProperties.updateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateInput
        # switch ( $PSCmdlet.ParameterSetName ){
        #     "updateProperties"{
        #         if($PSBoundParameters.ContainsKey('configuredSLADomainId')){
        #             $dbsUpdateProperties.updateProperties.configuredSLADomainId = $RscSlaDomain.id
        #         }
        #         if($PSBoundParameters.ContainsKey('isPaused')){
        #             $dbsUpdateProperties.updateProperties.isPaused = $isPaused
        #         }
        #         if($PSBoundParameters.ContainsKey('maxDataStreams')){
        #             $dbsUpdateProperties.updateProperties.maxDataStreams = $maxDataStreams
        #         }
        #         if($PSBoundParameters.ContainsKey('shouldForceFull')){
        #             $dbsUpdateProperties.updateProperties.shouldForceFull = $shouldForceFull
        #         }
        #     }
        #     "Add Pre-BackupScript" {
        #         $dbsUpdateProperties.updateProperties.preBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
        #         $dbsUpdateProperties.updateProperties.preBackupScript.scriptErrorAction = $scriptErrorAction
        #         $dbsUpdateProperties.updateProperties.preBackupScript.scriptPath = $scriptPath
        #         $dbsUpdateProperties.updateProperties.preBackupScript.timeoutMs = $timeoutMs
        #     }
        #     "Add Post-BackupScript"{
        #         $dbsUpdateProperties.updateProperties.postBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
        #         $dbsUpdateProperties.updateProperties.postBackupScript.scriptErrorAction = $scriptErrorAction
        #         $dbsUpdateProperties.updateProperties.postBackupScript.scriptPath = $scriptPath
        #         $dbsUpdateProperties.updateProperties.postBackupScript.timeoutMs = $timeoutMs
        #     }
        #     "Remove Pre-BackupScript"{
        #         $dbsUpdateProperties.updateProperties.preBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
        #         $dbsUpdateProperties.updateProperties.preBackupScript.scriptErrorAction = $null
        #         $dbsUpdateProperties.updateProperties.preBackupScript.scriptPath = $null
        #         $dbsUpdateProperties.updateProperties.preBackupScript.timeoutMs = $null
        #     }
        #     "Remove Post-BackupScript"{
        #         $dbsUpdateProperties.updateProperties.postBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
        #         $dbsUpdateProperties.updateProperties.postBackupScript.scriptErrorAction = $null
        #         $dbsUpdateProperties.updateProperties.postBackupScript.scriptPath = $null
        #         $dbsUpdateProperties.updateProperties.postBackupScript.timeoutMs = $null
        #     }
        #     "mssqlSlaRelatedProperties"{
        #         $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaRelatedPropertiesInput
        #         $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.copyOnly = $copyOnly
        #         $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla = $hasLogConfigFromSla
        #         $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.hostLogRetention = $hostLogRetention
        #         $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.logBackupFrequencyinSeconds = $logBackupFrequencyinSeconds
        #         $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.logRetentionHours = $logRetentionHours
        #     }
        # }
        # $query.Var.input.dbsUpdateProperties += $dbsUpdateProperties
        #endregion
        $query.Invoke()
        
    } 
}
