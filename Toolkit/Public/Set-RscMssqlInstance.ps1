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
        )][RubrikSecurityCloud.Types.PhysicalHost]$RscMssqlInstance,

        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $false,
            ParameterSetName = "Protect"
        )][RubrikSecurityCloud.Types.GlobalSlaReply]$RscSlaDomain,

        [Parameter(
            Mandatory = $false
        )][switch]$ShouldApplyToExistingSnapshots,

        [Parameter(
            Mandatory = $false
        )][switch]$CopyOnly,

        [Parameter(
            Mandatory = $false
        )][int]$LogBackupFrequencyInSeconds,

        [Parameter(
            Mandatory = $false
        )][int]$LogRetentionHours,

        [Parameter(
            Mandatory = $false
        )][switch]$HasLogConfigFromSla,

        [Parameter(
            Mandatory = $false
        )][int]$HostLogRetention,

        [Parameter(
            Mandatory = $false
        )][switch]$DoNotProtect


    )
    Process {
        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Debug "-Running Get-RscMssqlInstance"

        #region Create Query
        $query = New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
        $query.Var.input.userNote = ""

        
        switch ($PSCmdlet.ParameterSetName){
            "UnProtect"{
                $query.Var.input.updateinfo.ExistingSnapshotRetention = 'EXISTING_SNAPSHOT_RETENTION_RETAIN_SNAPSHOTS'
                $query.Var.input.updateinfo.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
                
            }
        }
        $query.Var.input.updateinfo.ids = @()
        $query.Var.input.updateinfo.ids += $RscMssqlInstance.PhysicalChildConnection.Nodes.id




        $query.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
        if ($ShouldApplyToExistingSnapshots){
            $query.Var.input.updateinfo.shouldApplyToExistingSnapshots = $true
        }
        else {
            $query.Var.input.updateinfo.shouldApplyToExistingSnapshots = $false
        }
        if ($ShouldApplyToNonPolicySnapshots){
            $query.Var.input.updateinfo.shouldApplyToNonPolicySnapshots = $true
        }
        else {
            $query.Var.input.updateinfo.shouldApplyToNonPolicySnapshots = $false
        }
        
        $query.Var.input.updateinfo.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
        $query.Var.input.updateinfo.mssqlSlaPatchProperties.configuredSlaDomainId = $RscSlaDomain.Id
        if ($UseConfiguredDefaultLogRetention){
            $query.Var.input.updateinfo.mssqlSlaPatchProperties.useConfiguredDefaultLogRetention = $true
        }
        else {
            $query.Var.input.updateinfo.mssqlSlaPatchProperties.useConfiguredDefaultLogRetention = $false
        }
                
        $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaRelatedPropertiesInput
        if ($CopyOnly){
            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.copyOnly = $true
        }
        else{
            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.copyOnly = $false
        }
        
        $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.logBackupFrequencyInSeconds = $LogBackupFrequencyInSeconds
        $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.logRetentionHours = $logRetentionHours
        if ($HasLogConfigFromSla){
            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla = $true
        }else {
            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla = $false
        }
        if ($hostLogRetention){
            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = $hostLogRetention
        }else {
            $query.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = -1
        }
        



        

    } 
}
