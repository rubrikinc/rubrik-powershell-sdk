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

    .PARAMETER Id
    Used to return a specific Availability Groups based on the Id assigned inside of Rubrik

    .PARAMETER Name
    Used to return a specific Availability Groups based on the name of the Availability Group
    
    .PARAMETER Cluster
    Cluster object retrieved via Get-RscCluster
    
    .PARAMETER Sla
    SLA object retrieved via Get-RscCluster

    .PARAMETER Relic
    Switch to include or exclude relics

    .PARAMETER Replica
    Switch to include or exclude replicated AGs

    .EXAMPLE
    Returns a list of Availability Groups in Rubrik, including relics and replicas.
    Get-RscMssqlAvailabilityGroup

    .EXAMPLE
    Returns information about a specific Availability Group based on the Rubrik ID
    Get-RscMssqlAvailabilityGroup -Id "86da734b-2fee-4fdc-bdc8-a73ab5648f" 

    .EXAMPLE
    Returns information about a specific Availability Group based on the name of the AG.
    Get-RscMssqlAvailabilityGroup -Name AG_Accounting -Relic:$false -Replica:$false

    .EXAMPLE
    Returns a list of Availability Groups that are connected to a specific Rubrik Cluster
    Get-RscCluster -Name "example" | Get-RscMssqlAvailabilityGroup -Relic:$false -Replica:$false

    .EXAMPLE
    Returns information about a specific Availability Group based on the name of the AG and the name of the Rubrik Cluster
    Get-RscCluster -Name "example" | Get-RscMssqlAvailabilityGroup -Name AG_Accounting -Relic:$false -Replica:$false
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        # DEPRECATED. Providing -List is superfluous. Running Get-RscMssqlAvailabilityGroup with no arguments will return a list. This argument will be ignored.
        [Parameter(ParameterSetName = "List", Mandatory = $false)]
        [Switch]$List,
        
        # Rubrik id of the availability group
        [Parameter(ParameterSetName = "Id",Mandatory = $true)]
        [String]$Id,

        # Name of the availability group
        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false,
            Position = 0
        )]
        [Alias("AvailabilityGroupName")] # standardizing on -Name across cmdlets. Leaving alias for backward compatibility.
        [String]$Name,

        # Sla Domain object
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true,
            ParameterSetName = "Name"
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,
        
        # Rubrik cluster
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true,
            ParameterSetName = "Name"
        )]
        [Alias("RscCluster")] # standardizing on -Cluster across cmdlets. Leaving alias for backward compatibility.
        [RubrikSecurityCloud.Types.Cluster]$Cluster,

        # DEPRECATED. -Detail was intended to provide a more detailed view of the objects, however the definitions of "detail" resulted in the potential to pull inaccessible fields.
        # Detail is now the default, and the field definition is managed in the cmdlet code.
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Detail,

        # Include Relics
        [Parameter(
            Mandatory = $false
        )]
        [switch]$Relic,

        # Include Replicas
        [Parameter(
            Mandatory = $false
        )]
        [switch]$Replica,

        # Return .NET query object for troubleshooting
        [Parameter(
            Mandatory = $false
        )]
        [switch]$AsQuery
    )
    
    Process {
        Write-Debug "- Running Get-RscMssqlAvailabilityGroup"

        $agFieldDef = Get-RscType -Name MssqlAvailabilityGroup -InitialProperties `
            name,`
            id,`
            cluster.name, cluster.id,`
            primaryClusterLocation.name, primaryClusterLocation.clusterUuid
        
        # This is required because Get-RscType sets it as a ClusterSla, not a globalSlaReply
        $agFieldDef.effectiveSlaDomain = Get-RscType -Name GlobalSlaReply -InitialProperties name,Id
        
         if ($Id) {
            $query = New-RscQuery -GqlQuery mssqlAvailabilityGroup
            $query.Var.filter = @()
            $query.Var.fid = $id
            $query.Field = $agFieldDef
            if ($PSBoundParameters.ContainsKey("AsQuery")) {
                $query
            }
            else {
                $query.invoke()
            }

         }
         else {
            $query = New-RscQuery -GqlQuery mssqlTopLevelDescendants
            $query.var.typeFilter = [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::MSSQL_AVAILABILITY_GROUP
            $query.Var.filter = @()
            $query.Field.Nodes = $agFieldDef

            if ($Name) {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                # Regex filter doesn't work in the API right now, but we're going to play pretend. 
                # With real Regex, users could search for VMs that start with the letter A if they wanted.
                if ($name.Contains("*")) {
                    $name.Replace("*",'')
                    $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::REGEX
                    $nameFilter.texts = $Name.Replace("*",'')
                } else {
                    $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                    $nameFilter.texts = $Name
                }
                $query.var.filter += $nameFilter
            }
            if ($Sla) {
                $slaFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $slaFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::EFFECTIVE_SLA
                $slaFilter.Texts = $Sla.id
                $query.var.filter += $slaFilter
            }
            if($Cluster) {
                $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
                $clusterFilter.texts = $Cluster.Id
                $query.Var.filter += $clusterFilter
            }
            if ($PSBoundParameters.ContainsKey('relic')) {
                $relicFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $relicFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_RELIC
                $relicFilter.Texts = $Relic
                $query.var.filter += $relicFilter
            }
            if ($PSBoundParameters.ContainsKey('replica')) {
                $replicaFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $replicaFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_REPLICATED
                $replicaFilter.Texts = $Replica
                $query.var.filter += $replicaFilter
            }

            if ($PSBoundParameters.ContainsKey("AsQuery")) {
                $query
            }
            else {
                $query.invoke().nodes
            }
         }
    } 
}
