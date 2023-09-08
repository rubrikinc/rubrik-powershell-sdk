#Requires -Version 3
function Get-RscMssqlDatabaseCRL {
    <#
    .SYNOPSIS
    Get SQL Server Databases

    .DESCRIPTION
    Get SQL Server Databases

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Get-RscMssqlDatabaseCRL
    or
    Get-RscMssqlDatabaseCRL -List
    Return back a list of SQL Server databases. Host and Instance information is located in PhysicalPath section

    .EXAMPLE
    Get-RscMssqlDatabaseCRL -Name master

    Return all databases with the name master. 

    .EXAMPLE
    Get-RscMssqlDatabaseCRL -Name master -InstanceID "f2c15060-85a5-54c4-95e7-7c4a948a3e19"

    Return the master database on a specific SQL Server Instance. InstanceId can be retrieved by using Get-RscMssqlInstance

    .EXAMPLE
    Get-RscMssqlDatabaseCRL -name master -InstanceID "f2c15060-85a5-54c4-95e7-7c4a948a3e19" -clusterId "39b92c18-d897-4b55-a7f9-17ff178616d0"

    Return the master database on a specific SQL Server Instance. InstanceId can be retrieved by using Get-RscMssqlInstance, and clusterId can be retrieved by using Get-RscCluster
    #>

    [CmdletBinding(DefaultParameterSetName = "List")]
    Param(
        # List parameter set:
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$List,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$Name,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [RubrikSecurityCloud.Types.PhysicalHost]$RscMssqlInstance,

        #  Common parameter to all parameter sets:
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

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$clusterId #= "39b92c18-d897-4b55-a7f9-17ff178616d0"
    )

    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) { $inputProfile = "DETAIL" }

        #region Add Additional Fields to Output
        $mssqlInputs = Invoke-RscQueryMssql -Databases -InputProfile $inputProfile -GetInput
        #endregion

        #region Base Filters
        $mssqlInputs.Var.filter = @()
        if($PSBoundParameters.ContainsKey('isRelic')) {
            $relicFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $relicFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_RELIC
            $relicFilter.texts = $isRelic
            $mssqlInputs.Var.filter += $relicFilter
        }

        if($PSBoundParameters.ContainsKey('isArchived')) {
            $archivedFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $archivedFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_ARCHIVED
            $archivedFilter.texts = $isArchived
            $mssqlInputs.Var.filter += $archivedFilter
        }

        if($PSBoundParameters.ContainsKey('clusterId')) {
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.texts = $clusterId
            $mssqlInputs.Var.filter += $clusterFilter
        }
        #endregion

        #region Add Additional Fields to Output
        $mssqlInputs.Field.Nodes[0].PhysicalPath = New-Object -TypeName RubrikSecurityCloud.Types.PathNode
        $mssqlInputs.Field.Nodes.PhysicalPath.Fid = "FETCH"
        $mssqlInputs.Field.Nodes.PhysicalPath.Name = "FETCH"
        $mssqlInputs.Field.Nodes.PhysicalPath.ObjectType = New-Object -TypeName RubrikSecurityCloud.Types.HierarchyObjectTypeEnum
        #endregion

        #region Filters
        $mssqlInputs.Var.filter = @()

        switch ( $PSCmdlet.ParameterSetName){
            # "List" {
            #     $query = { Invoke-RscQueryMssql -Databases -InputProfile $inputProfile -Input $mssqlInputs }
            # }
            "Name" {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $Name
                $mssqlInputs.Var.filter += $nameFilter
            }
        }
        $query = { Invoke-RscQueryMssql -Databases -InputProfile $inputProfile -Input $mssqlInputs }

        #endregion

        $result = (Invoke-Command -ScriptBlock $query)

        If ( $PSBoundParameters.ContainsKey('RscMssqlInstance') ) {
            $Instance = $RscMssqlInstance.PhysicalChildConnection.Nodes | Where-Object {$_.ObjectType -eq "MSSQL_INSTANCE"}
            $results = $result.Nodes | Where-Object { $_.PhysicalPath.Fid -eq $Instance.Id }
        }
        else {
            $results = Invoke-Command -ScriptBlock $query
        }

        if ([bool]($results.PSobject.Properties.name -match "Nodes")){
            $results.Nodes #| Remove-NullProperties
        }else{
            $results #| Remove-NullProperties
        }
    } 
}
