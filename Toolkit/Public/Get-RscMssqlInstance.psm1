#Requires -Version 3
function Get-RscMssqlInstance {
    <#
    .SYNOPSIS
    Get SQL Server Instances

    .DESCRIPTION
    Get SQL Server Instances

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Get-RscMssqlInstance
    or
    Get-RscMssqlInstance -List

    Will return back a list of SQL Server Instances. The data returned will be the host and the instance name and ID will be in the 
    PhysicalChildConnection field

    .EXAMPLE
    Get-RscMssqlInstance -Id "f2c15060-85a5-54c4-95e7-7c4a948a3e19"

    Returns SQL Server Instance information based on the object ID registered in Rubrik

    .EXAMPLE
    Get-RscMssqlInstance -hostName "sql1.domain.com" 

    Returns back informaiton about the SQL Server called SQL1. This could return back multiple entries if backups are beign replicated to another
    cluster. 

    .EXAMPLE
    Get-RscMssqlInstance -hostName "sql1.domain.com"  -clusterId "39b92c18-d897-4b55-a7f9-17ff178616d0"

    Returns back informaiton about the SQL Server called SQL1. This will return back the SQL Server for a specific Rurbik Cluster. You can get
    clusterId by using Get-RscCluster
    
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        # List parameter set:
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [Switch]$List #,

        # # Id parameter set:
        # [Parameter(
        #     ParameterSetName = "Id",
        #     Mandatory = $false, 
        #     ValueFromPipelineByPropertyName = $true
        # )]
        # [String]$Id,

        # # Name parameter set:
        # [Parameter(
        #     ParameterSetName = "HostName",
        #     Mandatory = $false, 
        #     ValueFromPipelineByPropertyName = $true
        # )]
        # [String]$HostName,

        # # Name parameter set:
        # [Parameter(
        #     ParameterSetName = "HostName",
        #     Mandatory = $false, 
        #     ValueFromPipelineByPropertyName = $true
        # )]
        # [String]$InstanceName = "MSSQLSERVER",

        # #  Common parameter to all parameter sets:
        # [Parameter(
        #     Mandatory = $false, 
        #     ValueFromPipelineByPropertyName = $true
        # )]
        # [Switch]$Detail,

        # [Parameter(
        #     Mandatory = $false, 
        #     ValueFromPipelineByPropertyName = $true
        # )]
        # [Switch]$isRelic,

        # [Parameter(
        #     Mandatory = $false, 
        #     ValueFromPipelineByPropertyName = $true
        # )]
        # [Switch]$isArchived,

        # [Parameter(
        #     Mandatory = $false, 
        #     ValueFromPipelineByPropertyName = $true
        # )]
        # [String]$clusterId = "39b92c18-d897-4b55-a7f9-17ff178616d0"
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine input profile:
        # $inputProfile = "DEFAULT"
        # if ( $Detail -eq $true ) {
        #     $inputProfile = "DETAIL"
        # }

        #region Create initial query
        $query = New-RscGqlQueryMssqlTopLevelDescendants -Patch Nodes.PhysicalPath
        #endregion

        #region Base Filters
        # $query.Var.filter = @()
        # if($PSBoundParameters.ContainsKey('isRelic')) {
        #     $relicFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
        #     $relicFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_RELIC
        #     $relicFilter.texts = $isRelic
        #     $query.Var.filter += $relicFilter
        # }

        # if($PSBoundParameters.ContainsKey('isArchived')) {
        #     $archivedFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
        #     $archivedFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_ARCHIVED
        #     $archivedFilter.texts = $isArchived
        #     $query.Var.filter += $archivedFilter
        # }

        # if($PSBoundParameters.ContainsKey('clusterId')) {
        #     $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
        #     $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
        #     $clusterFilter.texts = $clusterId
        #     $query.Var.filter += $clusterFilter
        # }
        #endregion
        
        #region Invoke GraphQL operation:
        # switch ( $PSCmdlet.ParameterSetName){
        #     "List" {
        #         # // TODO: Include Windows Clusters
        #         $query.Var.typeFilter = @("PhysicalHost", "WindowsCluster")
                
        #         # // TODO: Get-RSCPages with the below line. 
        #         # $query = { Invoke-RscQueryMssql -TopLevelDescendants -InputProfile $inputProfile -Patch "physicalChildConnection.Nodes" -Input $mssqlInputs }
        #     }
        #     "Id"  {
        #         # // TODO: Include Host information
        #         # $inputProfile = "DETAIL"
        #         # $in = (Invoke-RscQueryMssql -Instance -InputProfile $inputProfile -GetInput)
        #         $query.Var.fid = $id
        #         # $query = { Invoke-RscQueryMssql -Instance -Input $in -Patch "PhysicalPath" }
        #     }
        #     "HostName" {
        #         $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
        #         $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
        #         $nameFilter.texts = $Hostname
        #         $mssqlInputs.Var.filter += $nameFilter

        #         # $query = { Invoke-RscQueryMssql -TopLevelDescendants -InputProfile $inputProfile -Patch "physicalChildConnection.Nodes" -Input $mssqlInputs }
        #     }
        # }
        #endregion
        $result = $query.Invoke()
        # if ([bool]($result.PSobject.Properties.name -match "Nodes")){
        #     $result.Nodes #| Remove-NullProperties
        # }else{
        #     $result #| Remove-NullProperties
        # }
        
        
    } 
}
