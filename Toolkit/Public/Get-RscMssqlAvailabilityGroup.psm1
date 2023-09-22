#Requires -Version 3
function Get-RscMssqlAvailabilityGroup {
    <#
    .SYNOPSIS
 
    .DESCRIPTION
 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE

    .EXAMPLE

    .EXAMPLE

    .EXAMPLE
    
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
        [Switch]$List ,

        # Id parameter set:
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [String]$Id,

        # Name parameter set:
        [Parameter(
            ParameterSetName = "AGName",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [String]$AvailabilityGroupName,





        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [String]$clusterId
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null
        
        #region Invoke GraphQL operation:
        switch ( $PSCmdlet.ParameterSetName){
            "List" {
                $query = New-RscGqlQueryMssqlTopLevelDescendants -Patch Nodes.physicalChildConnection.Nodes
                $query.Var.filter = @()
                $query.Var.typeFilter = "MssqlAvailabilityGroup"
            }
            "Id"  {
                $query = New-RscGqlQueryMssqlAvailabilityGroup -Patch Nodes.PhysicalPath, Nodes.LogicalPath
                $query.Var.filter = @()
                $query.Var.fid = $id
            }
            "AGName" {
                $query = New-RscGqlQueryMssqlTopLevelDescendants -Patch Nodes.physicalChildConnection.Nodes
                $query.Var.filter = @()

                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $AvailabilityGroupName
                $query.Var.filter += $nameFilter
            }
        }
        #endregion

        if($PSBoundParameters.ContainsKey('clusterId')) {
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.texts = $clusterId
            $query.Var.filter += $clusterFilter
        }
        #endregion
        $result = $query.Invoke()

        # if ([bool]($result.PSobject.Properties.Name -match "Nodes")){
        if ($null -ne $result.Nodes){
            $result.Nodes #| Remove-NullProperties
        }else{
            $result #| Remove-NullProperties
        }
        
    } 
}
