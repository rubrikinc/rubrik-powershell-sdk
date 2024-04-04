#Requires -Version 3
function Set-RscMssqlInstance{
    <#
    .SYNOPSIS
    Sets properties of a MSSQL Instance in RSC

    .DESCRIPTION
    Sets properties of a MSSQL Instance in RSC

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlInstance
    Database object returned from Get-RscMssqlInstance

    .PARAMETER DoNotProtect
    Sets the protection property on the database to DO NOT PROTECT

    .PARAMETER ExistingSnapshotRetention
    Defines what should happen to existing snapshots when you set the database to DO NOT PROTECT

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

    .EXAMPLE
    Set-RscMssqlInstance -RscMssqlInstance $RscMssqlInstance -RscSlaDomain $RscSlaDomain
    #>
    Param(
        [Parameter(
            Mandatory = $false
        )][RubrikSecurityCloud.Types.MssqlInstance]$RscMssqlInstance, 

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
        )][switch]$ShouldApplyToNonPolicySnapshots
    )
    Process {
        Write-Debug "-Running Get-RscMssqlInstance"

        #region Create Query
        switch ($PSCmdlet.ParameterSetName){
            "Do Not Protect" {
                $query = New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
                $query.Var.input.userNote = ""
                $query.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
                $query.Var.input.updateinfo.ids = @()
                $query.Var.input.updateinfo.ids += $RscMssqlInstance.id
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
            "Apply SLA Domain"{
                $query = New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
                $query.Var.input.userNote = ""
                $query.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
                $query.Var.input.updateinfo.ids = @()
                $query.Var.input.updateinfo.ids += $RscMssqlInstance.id
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
            Default {}
        }
        
        $query.invoke()
    } 
}
