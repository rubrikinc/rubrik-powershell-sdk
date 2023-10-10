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

        [Parameter(Mandatory = $true)]
        [String]$ClusterId,

        [Parameter(Mandatory = $false)]
        [String]$SlaDomainId,

        [Parameter(Mandatory = $false)]
        [bool]$IsPaused,

        [Parameter(Mandatory = $false)]
        [int]$MaxDataStreams,

        [Parameter(Mandatory = $false)]
        [bool]$ShouldForceFull,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        [ValidateSet("SCRIPT_ERROR_ACTION_ABORT", "SCRIPT_ERROR_ACTION_CONTINUE")]
        [String]$PreBackupScriptErrorAction,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        [String]$PreBackupScriptPath,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        [int]$PreBackupScriptTimeoutMs,
        
        [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        [ValidateSet("SCRIPT_ERROR_ACTION_ABORT", "SCRIPT_ERROR_ACTION_CONTINUE")]
        [String]$PostBackupScriptErrorAction,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        [String]$PostBackupScriptPath,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        [int]$PostBackupScriptTimeoutMs,

        [Parameter(Mandatory = $false, ParameterSetName = "Remove Pre-BackupScript")]
        [Switch]$RemovePreBackupScript,

        [Parameter(Mandatory = $false, ParameterSetName = "Remove Post-BackupScript")]
        [Switch]$RemovePostBackupScript,

        [Parameter(Mandatory = $false)]
        [bool]$CopyOnly,
        
        [Parameter(Mandatory = $false)]
        [bool]$HasLogConfigFromSla,

        [Parameter(Mandatory = $false)]
        [int]$HostLogRetention,

        [Parameter(Mandatory = $false)]
        [int]$LogBackupFrequencyInSeconds,

        [Parameter(Mandatory = $false)]
        [int]$LogRetentionHours
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null
        Write-Host "Set-RscMssqlDatabase field profile: $fieldProfile"
        
        #region Create Query
        $query = New-RscMutationMssql -Operation BulkUpdateDbs

        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateMssqlDbsInput
        $query.Var.input.clusterUuid = $clusterId

        $query.Var.input.dbsUpdateProperties = @()
        $dbsUpdateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateIdInput
        $dbsUpdateProperties.databaseId = $RscMssqlDatabase.Id
        
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlNonSlaProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlNonSlaPropertiesInput
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlNonSlaProperties.copyOnly = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlNonSlaProperties.logBackupFrequencyinSeconds = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlNonSlaProperties.logRetentionHours = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlSlaPatchProperties.configuredSLADomainId = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlSlaPatchProperties.mssqlSlaRelatedProperties = 
        # $query.Var.input.dbsUpdateProperties.updateProperties.mssqlSlaPatchProperties.useConfiguredDefaultLogRetention = 
        
        $dbsUpdateProperties.updateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateInput
        switch ( $PSCmdlet.ParameterSetName ){
            "updateProperties"{
                if($PSBoundParameters.ContainsKey('configuredSLADomainId')){
                    $dbsUpdateProperties.updateProperties.configuredSLADomainId = $SlaDomainId
                }
                if($PSBoundParameters.ContainsKey('isPaused')){
                    $dbsUpdateProperties.updateProperties.isPaused = $isPaused
                }
                if($PSBoundParameters.ContainsKey('maxDataStreams')){
                    $dbsUpdateProperties.updateProperties.maxDataStreams = $maxDataStreams
                }
                if($PSBoundParameters.ContainsKey('shouldForceFull')){
                    $dbsUpdateProperties.updateProperties.shouldForceFull = $shouldForceFull
                }
            }
            "Add Pre-BackupScript" {
                $dbsUpdateProperties.updateProperties.preBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
                $dbsUpdateProperties.updateProperties.preBackupScript.scriptErrorAction = $scriptErrorAction
                $dbsUpdateProperties.updateProperties.preBackupScript.scriptPath = $scriptPath
                $dbsUpdateProperties.updateProperties.preBackupScript.timeoutMs = $timeoutMs
            }
            "Add Post-BackupScript"{
                $dbsUpdateProperties.updateProperties.postBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
                $dbsUpdateProperties.updateProperties.postBackupScript.scriptErrorAction = $scriptErrorAction
                $dbsUpdateProperties.updateProperties.postBackupScript.scriptPath = $scriptPath
                $dbsUpdateProperties.updateProperties.postBackupScript.timeoutMs = $timeoutMs
            }
            "Remove Pre-BackupScript"{
                $dbsUpdateProperties.updateProperties.preBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
                $dbsUpdateProperties.updateProperties.preBackupScript.scriptErrorAction = $null
                $dbsUpdateProperties.updateProperties.preBackupScript.scriptPath = $null
                $dbsUpdateProperties.updateProperties.preBackupScript.timeoutMs = $null
            }
            "Remove Post-BackupScript"{
                $dbsUpdateProperties.updateProperties.postBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
                $dbsUpdateProperties.updateProperties.postBackupScript.scriptErrorAction = $null
                $dbsUpdateProperties.updateProperties.postBackupScript.scriptPath = $null
                $dbsUpdateProperties.updateProperties.postBackupScript.timeoutMs = $null
            }
            "mssqlSlaRelatedProperties"{
                $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaRelatedPropertiesInput
                $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.copyOnly = $copyOnly
                $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla = $hasLogConfigFromSla
                $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.hostLogRetention = $hostLogRetention
                $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.logBackupFrequencyinSeconds = $logBackupFrequencyinSeconds
                $dbsUpdateProperties.updateProperties.mssqlSlaRelatedProperties.logRetentionHours = $logRetentionHours
            }
        }
        $query.Var.input.dbsUpdateProperties += $dbsUpdateProperties
        #endregion
        $query.Invoke()
        
    } 
}
