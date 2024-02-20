#Requires -Version 3
function Get-RscMssqlAvailabilityGroup {
    <#
    .SYNOPSIS
    Retrieve info about MSSQL Availability Groups

    .DESCRIPTION
    Retrieve info about MSSQL Availability Groups. An Availability Group is a Parent Object to a database. 
    If your database is in an AG, then you will want to use this cmdlet, but if not you will want to get the Instance information
    using Get-RscMssqlInstance.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Used to create a list of Availability Groups
    .PARAMETER Id
    Used to return a specific Availability Groups based on the Id assigned inside of Rubrik

    .PARAMETER AvailabilityGroupName
    Used to return a specific Availability Groups based on the name of the Availability Group
    
     .PARAMETER RscCluster
    RscCluster object retrieved via Get-RscCluster
    
    .PARAMETER Detail
    Changes the data profile. This can affect the fields returned

    .EXAMPLE
    Returns a list of Availbility Groups that are connected to Rubrik
    Get-RscMssqlAvailabilityGroup -List

    .EXAMPLE
    Returns information about a specific Availability Group based on the Rubrik ID
    Get-RscMssqlAvailabilityGroup -Id "86da734b-2fee-4fdc-bdc8-a73ab5648f" 

    .EXAMPLE
    Returns information about a specific Availability Group based on the name of the AG.
    Get-RscMssqlAvailabilityGroup -Name AG_Accounting

    .EXAMPLE
    Returns a list of Availbility Groups that are connected to a specific Rubrik Cluster
    Get-RscMssqlAvailabilityGroup -List -clusterID hja87-ajb43-v4avna-hnjag

    .EXAMPLE
    Returns information about a specific Availability Group based on the name of the AG and the name of the Rubrik Cluster
    Get-RscMssqlAvailabilityGroup -Name AG_Accounting -clusterID hja87-ajb43-v4avna-hnjag

    .EXAMPLE
    Return back all fields, including the fields that are null
    
    Get-RscMssqlAvailabilityGroup -Name AG_Accounting -IncludeNullProperties

    .EXAMPLE
    Return back just the query that will be run instead of running the query and returning the results

    Get-RscMssqlAvailabilityGroup -Name AG_Accounting -AsQuery   
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )][Switch]$List,
        
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$Id,

        [Parameter(
            ParameterSetName = "AvailabilityGroupName",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$AvailabilityGroupName,
        
        [Parameter(
            Mandatory = $false
        )][RubrikSecurityCloud.Types.Cluster]$RscCluster,

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Detail
    )
    
    Process {
        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Debug "- Running Get-RscMssqlAvailabilityGroup"
        
         #region Create Query
         switch ( $PSCmdlet.ParameterSetName ){
            "List" {
                $query = New-RscQueryMssql -Operation TopLevelDescendants -FieldProfile $fieldProfile
                $query.Var.filter = @()
                $query.Var.typeFilter = "MssqlAvailabilityGroup"
            }
            "Id"  {
                $query = New-RscQueryMssql -Op AvailabilityGroup -FieldProfile $fieldProfile -AddField PhysicalPath
                $query.Var.filter = @()
                $query.Var.fid = $id
            }
            "AvailabilityGroupName" {
                $query = New-RscQueryMssql -Op TopLevelDescendants -FieldProfile $fieldProfile
                $query.Var.filter = @()
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $AvailabilityGroupName
                $query.Var.filter += $nameFilter
            }
        }
        #endregion

        #region filters
        if($PSBoundParameters.ContainsKey('clusterId')) {
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.texts = $RscCluster.Id
            $query.Var.filter += $clusterFilter
        }
        #endregion
        $result = $query.Invoke()
        
        $result.Nodes
    } 
}
