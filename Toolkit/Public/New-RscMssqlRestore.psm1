
#Requires -Version 3
function New-RscMssqlRestore {
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
    )]
    Param(
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [switch]$FinishRecovery,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [int]$maxDataStreams,

        [Parameter(
            ParameterSetName = 'Recovery_DateTime',
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [datetime]$RecoveryDateTime,

        [Parameter(
            ParameterSetName = 'Recovery_LSN',
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [string]$RecoveryLSN
    )
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        #region Create Query
        $query = New-RscGqlMutationRestoreMssqlDatabase
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.RestoreMssqlDatabaseInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        
        $query.Var.input.config = New-Object RubrikSecurityCloud.Types.RestoreMssqlDbJobConfigInput
        $query.Var.input.config.finishRecovery = $FinishRecovery
        # If (![string]::IsNullOrEmpty($maxDataStreams)){$query.Var.input.config.maxDataStreams = $maxDataStreams}
        

        switch ($PSCmdLet.ParameterSetName) {
            "Recovery_DateTime" {
                $query.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
                $query.Var.input.config.recoveryPoint.date = $RecoveryDateTime
            }
            "Recovery_LSN" {
                $query.Var.input.config.recoveryPoint.lsnPoint = New-Object RubrikSecurityCloud.Types.LsnRecoveryPointInput
                $query.Var.input.config.recoveryPoint.lsnPoint.lsn
                $query.Var.input.config.recoveryPoint.lsnPoint.recoveryForkGuid
            }
        }
        #endregion
        
        $query.Invoke()

    } 
}
