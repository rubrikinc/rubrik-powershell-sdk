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

    .EXAMPLE
    Returns a list of Availbility Groups that are connected to Rubrik
    Get-RscMssqlAvailabilityGroup -List

    .EXAMPLE
    Returns information about a specific Availability Group based on the Rubrik ID
    Get-RscMssqlAvailabilityGroup -Id

    .EXAMPLE
    Returns information about a specific Availability Group based on the name of the AG.
    Get-RscMssqlAvailabilityGroup -Name AG_Accounting

    .EXAMPLE
    Returns a list of Availbility Groups that are connected to a specific Rubrik Cluster
    Get-RscMssqlAvailabilityGroup -List -clusterID hja87-ajb43-v4avna-hnjag

    .EXAMPLE
    Returns information about a specific Availability Group based on the name of the AG and the name of the Rubrik Cluster
    Get-RscMssqlAvailabilityGroup -Name -clusterID hja87-ajb43-v4avna-hnjag
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipeline = $false
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
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$clusterId,

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Detail,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$IncludeNullProperties,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$AsQuery
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlAvailabilityGroup field profile: $fieldProfile"
        
         #region Create Query
         switch ( $PSCmdlet.ParameterSetName ){
            "List" {
                # // TODO: SPARK-278997 Include Windows Clusters
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
            $clusterFilter.texts = $clusterId
            $query.Var.filter += $clusterFilter
        }
        #endregion

        $result = $query.Invoke()
        switch ( $PSCmdlet.ParameterSetName ){
            "HostName" {
                $result = $result | Where-Object {$_.Nodes.PhysicalChildConnection.Nodes.Name -eq $InstanceName}
            }
        }

        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }

        if ($null -ne $result.Nodes){
            if ( $IncludeNullProperties -eq $true ) {
                $result.Nodes
            }else{
                $result.Nodes | Remove-NullProperties
            }
        }else{
            if ( $IncludeNullProperties -eq $true ) {
                $result
            }else{
                $result | Remove-NullProperties
            }
        }  
    } 
}
