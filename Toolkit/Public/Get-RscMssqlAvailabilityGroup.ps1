#Requires -Version 3
function Get-RscMssqlAvailabilityGroup {
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

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Detail
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
                # // TODO: Include Windows Clusters
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

        if ($null -ne $result.Nodes){
            $result.Nodes #| Remove-NullProperties
        }else{
            $result #| Remove-NullProperties
        }
    } 
}