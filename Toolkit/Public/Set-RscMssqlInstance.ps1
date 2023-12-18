#Requires -Version 3
function Set-RscMssqlInstance{
    <#
    .SYNOPSIS
    Returns information about the SQL Server Instances connected to Rubrik Security Cloud

    .DESCRIPTION
    Returns information about the SQL Server Instances connected to Rubrik Security Cloud

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference



    .PARAMETER RscHost
    RscHost object retrieved via Get-RscHost

    .PARAMETER InstanceName
    SQL Server Instance Name
    
    .PARAMETER Id
    Used to return a specific SQL Server Instance based on the Id assigned inside of Rubrik
    
    .PARAMETER RscCluster
    RscCluster object retrieved via Get-RscCluster

    .PARAMETER Detail
    Changes the data profile. This can affect the fields returned

    .EXAMPLE
    Returns a list of all SQL Server Instances connected to RSC
    Get-RscMssqlInstance -List

    .EXAMPLE
    Returns information about the default instance of SQL on a specific host
    $HostName = "rp-sql19s-001.demo.rubrik.com"
    $RscHost = Get-RscHost -Name $HostName -OsType Windows
    $RscMssqlInstance = Get-RscMssqlInstance -RscHost $RscHost
    
    .EXAMPLE
    Returns information about a specific instance of SQL on a specific host
    $HostName = "rp-sql19s-001.demo.rubrik.com"
    $RscHost = Get-RscHost -Name $HostName -OsType Windows
    $RscMssqlInstance = Get-RscMssqlInstance -RscHost $RscHost -InstanceName DEV01
    
        .EXAMPLE
    Return a RscMssqlInstance Object based on a specific MssqlInstance Id
    Get-RscMssqlInstance -Id "86da734b-2fee-4fdc-bdc8-a73ab5648f" 
    #>

    # [CmdletBinding(
    #     DefaultParameterSetName = ""
    # )]
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
