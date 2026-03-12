#Requires -Version 3
function Set-RscMssqlAvailabilityGroup{
    <#
    .SYNOPSIS
    Configures protection settings for a Microsoft SQL Server Always On Availability Group.

    .DESCRIPTION
    Sets SLA Domain assignment and SQL Server-specific protection properties on an Availability Group. You can assign an SLA, set the AG to DO NOT PROTECT, configure log backup settings (frequency, retention, and host log retention), and control whether changes apply to existing snapshots. Use Get-RscMssqlAvailabilityGroup to obtain the AG object.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlAvailabilityGroup
    The Availability Group object. Pipe from Get-RscMssqlAvailabilityGroup.

    .PARAMETER DoNotProtect
    Remove SLA protection from the Availability Group.

    .PARAMETER ExistingSnapshotRetention
    What to do with existing snapshots when setting to DO NOT PROTECT: EXPIRE_IMMEDIATELY, KEEP_FOREVER, or RETAIN_SNAPSHOTS.

    .PARAMETER RscSlaDomain
    An SLA Domain object to assign. Pipe from Get-RscSla.

    .PARAMETER CopyOnly
    Take copy-only snapshots, which do not interfere with native SQL Server backup chains.

    .PARAMETER EnableLogBackups
    Enable transaction log backups. Omit to disable log backups.

    .PARAMETER UseSLALogConfig
    Use the log backup configuration defined in the SLA Domain instead of custom settings.

    .PARAMETER logBackupFrequencyInSeconds
    Custom log backup frequency in seconds. Required when -EnableLogBackups is set without -UseSLALogConfig.

    .PARAMETER logRetentionHours
    Custom log backup retention in hours. Required when -EnableLogBackups is set without -UseSLALogConfig.

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

    .EXAMPLE
    Assign an SLA Domain to an Availability Group.

    $ag = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "MyAG"
    $sla = Get-RscSla -Name "Gold"
    Set-RscMssqlAvailabilityGroup -RscMssqlAvailabilityGroup $ag -RscSlaDomain $sla

    .EXAMPLE
    Assign an SLA with log backups using the SLA log configuration.

    $ag = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "MyAG"
    $sla = Get-RscSla -Name "Gold"
    Set-RscMssqlAvailabilityGroup -RscMssqlAvailabilityGroup $ag -RscSlaDomain $sla -EnableLogBackups -UseSLALogConfig
    #>
    Param(
        [Parameter(
            Mandatory = $false
        )][RubrikSecurityCloud.Types.MssqlAvailabilityGroup]$RscMssqlAvailabilityGroup, 

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
                $query = New-RscMutation -Gql assignMssqlSlaDomainPropertiesAsync
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
                $query.Var.input.userNote = ""
                $query.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
                $query.Var.input.updateinfo.ids = @()
                $query.Var.input.updateinfo.ids += $RscMssqlAvailabilityGroup.id
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
                $query = New-RscMutation -Gql assignMssqlSlaDomainPropertiesAsync
                $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
                $query.Var.input.userNote = ""
                $query.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
                $query.Var.input.updateinfo.ids = @()
                $query.Var.input.updateinfo.ids += $RscMssqlAvailabilityGroup.id
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
