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

    Will return back a list of SQL Server Instances. The data returned will be the host and the instnace name nad ID will be in the 
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
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$List,

        # Id parameter set:
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$Id,

        # Name parameter set:
        [Parameter(
            ParameterSetName = "HostName",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$HostName,

        # Name parameter set:
        [Parameter(
            ParameterSetName = "HostName",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$InstanceName = "MSSQLSERVER",

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$Detail,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$isRelic,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$isArchived,

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
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }
        # Write-Host "Get-RscMssqlInstance: $inputProfile"
        # Write-Host "Get-RscMssqlInstance: $($PSCmdlet.ParameterSetName)"        
           
        #region Base Filters
        if($PSBoundParameters.ContainsKey('isRelic')) {
            $relicFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $relicFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_RELIC
            $relicFilter.texts = $isRelic
        }

        if($PSBoundParameters.ContainsKey('isArchived')) {
            $archivedFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $archivedFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_ARCHIVED
            $archivedFilter.texts = $isArchived
        }

        if($PSBoundParameters.ContainsKey('clusterId')) {
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.texts = $clusterId
        }
        #endregion
        
        #region Invoke GraphQL operation:
        switch ( $PSCmdlet.ParameterSetName){
            "List" {
                $in = (Invoke-RscQueryMssql -TopLevelDescendants -InputProfile $inputProfile -GetInput)
                # // TODO: Figure out way to include Windows Clusters
                $in.Var.typeFilter = "PhysicalHost" #, "WindowsCluster")
                $result = (Invoke-RscQueryMssql -TopLevelDescendants -Input $in -Patch "physicalChildConnection.Nodes").Nodes
            }

            "Id"  {
                # // TODO: Include Host information
                # $inputProfile = "DETAIL"
                $in = (Invoke-RscQueryMssql -Instance -InputProfile $inputProfile -GetInput)
                $in.Var.fid = $id
                $result = (Invoke-RscQueryMssql -Instance -Input $in -Patch "PhysicalPath")
            }

            "HostName" {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $Hostname

                $mssqlInputs = Invoke-RscQueryMssql -TopLevelDescendants -GetInput
                $mssqlInputs.Var.filter = @()
                
                if ( -not [string]::IsNullOrEmpty( $relicFilter ) ) {
                    $mssqlInputs.Var.filter += $relicFilter
                }
                if ( -not [string]::IsNullOrEmpty( $archivedFilter ) ) {
                    $mssqlInputs.Var.filter += $archivedFilter
                }
                if ( -not [string]::IsNullOrEmpty( $clusterFilter ) ) {
                    $mssqlInputs.Var.filter += $clusterFilter
                }
                $mssqlInputs.Var.filter += $nameFilter
                $result = (Invoke-RscQueryMssql -TopLevelDescendants -Input $mssqlInputs).nodes 

            }
        }
        #endregion
        $result | Remove-NullProperties
    } 
}
