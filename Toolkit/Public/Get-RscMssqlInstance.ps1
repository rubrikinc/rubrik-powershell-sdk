#Requires -Version 3
function Get-RscMssqlInstance{
    <#
    .SYNOPSIS
    Returns information about the SQL Server Instances connected to Rubrik Security Cloud

    .DESCRIPTION
    Returns information about the SQL Server Instances connected to Rubrik Security Cloud

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Uses the latest recovery point date and time that Rubrik has for a database

    .PARAMETER HostName
    Host name of the SQL Server Instance

    .PARAMETER WindowsClusterName
    Windows Cluster Name of the SQL Server Instance

    .PARAMETER InstanceName
    SQL Server Instance Name. If not provided, we default to MSSQLSERVER
    
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
    $RscMssqlInstance = Get-RscMssqlInstance -HostName $HostName
    
    .EXAMPLE
    Returns information about a specific instance of SQL on a specific host
    $HostName = "rp-sql19s-001.demo.rubrik.com"
    $RscMssqlInstance = Get-RscMssqlInstance -HostName $HostName -InstanceName DEV01

    .EXAMPLE
    Returns information about a specific instance of SQL on a Windows Cluster
    $WindowsClusterName = "rp-winfcsql"
    $RscMssqlInstance = Get-RscMssqlInstance -WindowsClusterName $WindowsClusterName -InstanceName DEV01
    
    .EXAMPLE
    Return a RscMssqlInstance Object based on a specific MssqlInstance Id
    Get-RscMssqlInstance -Id "86da734b-2fee-4fdc-bdc8-a73ab5648f" 
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(ParameterSetName = "List",Mandatory = $false)]
        [Switch]$List,
        
        [Parameter(ParameterSetName = "ByHostName", Mandatory = $true)]
        [String]$HostName,
        
        [Parameter(ParameterSetName = "ByWindowsClusterName", Mandatory = $true)]
        [String]$WindowsClusterName,

        [Parameter(ParameterSetName = "ByHostName", Mandatory = $false)]
        [Parameter(ParameterSetName = "ByWindowsClusterName", Mandatory = $false)]
        [String]$InstanceName = "MSSQLSERVER",
        
        [Parameter(ParameterSetName = "Id", Mandatory = $true)]
        [String]$Id,
       
        [Parameter(Mandatory = $false)]
        [RubrikSecurityCloud.Types.Cluster]$RscCluster,

        # Common parameter to all parameter sets:
        [Parameter(Mandatory = $false, ValueFromPipeline = $false)]
        [Switch]$Detail
    )
    Process {
        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Verbose "-Running Get-RscMssqlInstance"
        #region Create Query
        switch($PSCmdlet.ParameterSetName){
            "List"{
                Write-Verbose "-  Creating List Query"
                $query = New-RscQueryMssql -Op TopLevelDescendants -FieldProfile $fieldProfile
                $query.Var.typeFilter = @()
                $query.Var.typeFilter += "PhysicalHost"
                $query.Var.typeFilter += "WindowsCluster"
            }
            {($_ -eq "ByHostName") -or ($_ -eq "ByWindowsClusterName")}{
                $Name = ""
                if($HostName){$Name = $HostName}
                if($WindowsClusterName){$Name = $WindowsClusterName}
                $query = New-RscQueryMssql -Operation TopLevelDescendants -FieldProfile $fieldProfile 
                $query.Var.filter = @()
                $query.Field.Nodes[3].PhysicalChildConnection.Nodes[5].Cluster = New-Object RubrikSecurityCloud.Types.Cluster
                $query.Field.Nodes[3].PhysicalChildConnection.Nodes[5].Cluster.SelectForRetrieval()
                $query.Field.Nodes[3].PhysicalChildConnection.Nodes[5].PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
                $query.Field.Nodes[3].PhysicalChildConnection.Nodes[5].PhysicalPath.SelectForRetrieval()
    
                $query.field.Nodes[4].LogicalChildConnection = New-Object RubrikSecurityCloud.Types.WindowsClusterLogicalChildTypeConnection
                $query.field.Nodes[4].LogicalChildConnection.SelectForRetrieval()
                $query.Field.Nodes[4].LogicalChildConnection.Nodes[0].PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
                $query.Field.Nodes[4].LogicalChildConnection.Nodes[0].PhysicalPath.SelectForRetrieval()
    
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $Name
                $query.Var.filter += $nameFilter
            }
            "Id"{
                Write-Verbose "-  Creating Id Query"
                $query = New-RscQueryMssql -Operation Instance -FieldProfile $fieldProfile
                $query.Field.PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
                $query.Field.PhysicalPath.SelectForRetrieval()
                $query.Var.filter = @()
                $query.Var.fid = $id
            }
        }
        
        if ($PSBoundParameters.ContainsKey('RscCluster')) {
            Write-Verbose "-  Creating Cluster Filter"
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.texts = $RscCluster.Id
            $query.Var.filter += $clusterFilter
        }
        #endregion
        
        $results = $query.Invoke()

        switch($PSCmdlet.ParameterSetName){
            "List"{
                $results.Nodes
            }
            {($_ -eq "ByHostName") -or ($_ -eq "ByWindowsClusterName")}{
                switch($results.nodes.objectType){
                    "PHYSICAL_HOST"{
                        $results = $results.Nodes.PhysicalChildConnection.Nodes | Where-Object {$_.Name -eq $InstanceName}
                    }
                    "WINDOWS_CLUSTER"{
                        $results = $results.Nodes.LogicalChildConnection.Nodes | Where-Object {$_.Name -eq $InstanceName}
                    }
                }
                [RubrikSecurityCloud.Types.MssqlInstance]$results
            }
            "Id"{
                $results
            }
        }
    } 
}
