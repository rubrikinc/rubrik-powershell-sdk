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

    [CmdletBinding(
        # ___ Example ___
        DefaultParameterSetName = ""
    )]
    Param(
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(Mandatory = $true)]
        [String]$clusterId,

        [Parameter(Mandatory = $false, ParameterSetName = "updateProperties")]
        [String]$SlaDomainId,

        [Parameter(Mandatory = $false, ParameterSetName = "updateProperties")]
        [bool]$isPaused,

        [Parameter(Mandatory = $false, ParameterSetName = "updateProperties")]
        [int]$maxDataStreams,

        [Parameter(Mandatory = $false, ParameterSetName = "updateProperties")]
        [bool]$shouldForceFull,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        [Switch]$AddPreBackupScript,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        [Switch]$AddPostBackupScript,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        [Parameter(Mandatory = $false,  ParameterSetName = "pre/postBackupScript")]
        [ValidateSet("SCRIPT_ERROR_ACTION_ABORT", "SCRIPT_ERROR_ACTION_CONTINUE")]
        [String]$scriptErrorAction,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        [Parameter(Mandatory = $false,  ParameterSetName = "pre/postBackupScript")]
        [String]$scriptPath,

        [Parameter(Mandatory = $false, ParameterSetName = "Add Pre-BackupScript")]
        [Parameter(Mandatory = $false, ParameterSetName = "Add Post-BackupScript")]
        [Parameter(Mandatory = $false,  ParameterSetName = "pre/postBackupScript")]
        [int]$timeoutMs,

        [Parameter(Mandatory = $false, ParameterSetName = "Remove Pre-BackupScript")]
        [Switch]$RemovePreBackupScript,

        [Parameter(Mandatory = $false, ParameterSetName = "Remove Post-BackupScript")]
        [Switch]$RemovePostBackupScript,

        [Parameter(Mandatory = $false, ParameterSetName = "mssqlSlaRelatedProperties")]
        [bool]$copyOnly,
        
        [Parameter(Mandatory = $false, ParameterSetName = "mssqlSlaRelatedProperties")]
        [bool]$hasLogConfigFromSla,

        [Parameter(Mandatory = $false, ParameterSetName = "mssqlSlaRelatedProperties")]
        [int]$hostLogRetention,

        [Parameter(Mandatory = $false, ParameterSetName = "mssqlSlaRelatedProperties")]
        [int]$logBackupFrequencyInSeconds,

        [Parameter(Mandatory = $false, ParameterSetName = "mssqlSlaRelatedProperties")]
        [int]$logRetentionHours
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

        switch ( $PSCmdlet.ParameterSetName ){
            "updateProperties"{
                $dbsUpdateProperties.updateProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbUpdateInput
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
                # $dbsUpdateProperties.updateProperties.preBackupScript.scriptErrorAction = ""
                # $dbsUpdateProperties.updateProperties.preBackupScript.scriptPath = $null
                # $dbsUpdateProperties.updateProperties.preBackupScript.timeoutMs = $null
            }
            "Remove Post-BackupScript"{
                $dbsUpdateProperties.updateProperties.postBackupScript = New-Object -TypeName RubrikSecurityCloud.Types.MssqlScriptDetailInput
                # $dbsUpdateProperties.updateProperties.postBackupScript.scriptErrorAction = $null
                # $dbsUpdateProperties.updateProperties.postBackupScript.scriptPath = $null
                # $dbsUpdateProperties.updateProperties.postBackupScript.timeoutMs = $null
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
