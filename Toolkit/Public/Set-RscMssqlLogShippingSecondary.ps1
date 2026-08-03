#Requires -Version 3
function Set-RscMssqlLogShippingSecondary {
    <#
    .SYNOPSIS
    Updates the configuration of a SQL Server log shipping secondary database.

    .DESCRIPTION
    Modifies settings on an existing log shipping secondary target managed by
    Rubrik. Two parameter sets are supported:

    - AutomaticReseed (default): enables or disables automatic reseed when the
      primary transaction log chain breaks. Uses the -AutomaticReseed switch;
      omitting the switch disables automatic reseed.

    - State: changes the secondary's operating state (RESTORING or STANDBY)
      and optionally disconnects standby users when log backups are applied.

    The log shipping target object is typically obtained from
    Get-RscMssqlLogShipping.

    .PARAMETER RscMssqlLogShipping
    A log shipping target object, typically obtained from Get-RscMssqlLogShipping.

    .PARAMETER AutomaticReseed
    Enable automatic reseed when the primary transaction log chain breaks.
    Omit the switch to disable automatic reseed.

    .PARAMETER State
    The operating state of the log shipping secondary.
    RESTORING: secondary is in restore mode (no read access).
    STANDBY: secondary is in standby mode (read-only access).

    .PARAMETER DisconnectStandbyUsers
    Automatically disconnect users from the secondary when applying log backups.
    Only applicable when using the State parameter set.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Enable automatic reseed on a log shipping secondary.

    $logShipping = Get-RscMssqlLogShipping -RscMssqlDatabase $db -SecondaryDatabaseName "AW_Secondary" -RscCluster $cluster
    Set-RscMssqlLogShippingSecondary -RscMssqlLogShipping $logShipping -AutomaticReseed

    .EXAMPLE
    Disable automatic reseed on a log shipping secondary.

    $logShipping = Get-RscMssqlLogShipping -RscMssqlDatabase $db -SecondaryDatabaseName "AW_Secondary" -RscCluster $cluster
    Set-RscMssqlLogShippingSecondary -RscMssqlLogShipping $logShipping

    .EXAMPLE
    Change the secondary to STANDBY mode and disconnect users on log apply.

    $logShipping = Get-RscMssqlLogShipping -RscMssqlDatabase $db -SecondaryDatabaseName "AW_Secondary" -RscCluster $cluster
    Set-RscMssqlLogShippingSecondary -RscMssqlLogShipping $logShipping -State STANDBY -DisconnectStandbyUsers

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference
    #>

    [CmdletBinding(DefaultParameterSetName = "AutomaticReseed")]
    Param(
        [Parameter(
            Mandatory = $true,
            ValueFromPipeline = $true,
            ParameterSetName = "AutomaticReseed"
        )]
        [Parameter(
            Mandatory = $true,
            ValueFromPipeline = $true,
            ParameterSetName = "State"
        )]
        [RubrikSecurityCloud.Types.MssqlLogShippingTarget]$RscMssqlLogShipping,

        [Parameter(
            ParameterSetName = "AutomaticReseed",
            Mandatory = $false
        )]
        [Switch]$AutomaticReseed,

        [Parameter(
            ParameterSetName = "State",
            Mandatory = $true
        )]
        [ValidateSet("RESTORING", "STANDBY")]
        [String]$State,

        [Parameter(
            ParameterSetName = "State",
            Mandatory = $false
        )]
        [Switch]$DisconnectStandbyUsers,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )]
        [Switch]$AsQuery
    )

    Process {
        Write-Debug "- Running Set-RscMssqlLogShippingSecondary"

        if ($PSCmdlet.ParameterSetName -eq "State") {
            #region Create Query (updateMssqlLogShippingConfigurationV1)
            $query = New-RscMutation -Gql updateMssqlLogShippingConfigurationV1
            $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.UpdateMssqlLogShippingConfigurationV1Input
            $query.Var.input.Id = $RscMssqlLogShipping.Fid
            $query.Var.input.Config = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingUpdateInput
            $query.Var.input.Config.MssqlLogShippingTargetStateOptions = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetStateOptionsInput
            $query.Var.input.Config.MssqlLogShippingTargetStateOptions.ShouldDisconnectStandbyUsers = [bool]$DisconnectStandbyUsers
            switch ($State) {
                "RESTORING" {
                    $query.Var.input.Config.MssqlLogShippingTargetStateOptions.State = "MSSQL_LOG_SHIPPING_OK_STATE_RESTORING"
                }
                "STANDBY" {
                    $query.Var.input.Config.MssqlLogShippingTargetStateOptions.State = "MSSQL_LOG_SHIPPING_OK_STATE_STANDBY"
                }
            }
            #endregion
        } else {
            #region Create Query (updateMssqlLogShippingConfiguration)
            $query = New-RscMutation -Gql updateMssqlLogShippingConfiguration
            $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.UpdateMssqlLogShippingConfigurationInput
            $query.Var.input.Id = $RscMssqlLogShipping.CdmId
            $query.Var.input.ClusterUuid = $RscMssqlLogShipping.Cluster.Id
            $query.Var.input.Config = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingUpdateV2Input
            if ($AutomaticReseed) {
                $query.Var.input.Config.MakeupReseedLimit = 1
            } else {
                $query.Var.input.Config.MakeupReseedLimit = 0
            }
            #endregion
        }

        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    }
}
