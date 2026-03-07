#Requires -Version 3
function Get-RscAwsNativeEc2Instance {
    <#
    .SYNOPSIS
    Retrieves AWS EC2 instances managed by Rubrik Security Cloud.

    .DESCRIPTION
    Returns AWS native EC2 instances that are protected or inventoried by Rubrik.
    You can filter by name, SLA Domain, or cluster. Use -Id to retrieve a single
    instance by its RSC identifier.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Id
    The RSC object ID.

    .PARAMETER Name
    Filter by name. Supports partial matching.

    .PARAMETER Sla
    An SLA Domain object to filter by. Pipe from Get-RscSla.

    .PARAMETER Cluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

    .EXAMPLE
    # Get all AWS EC2 instances
    Get-RscAwsNativeEc2Instance

    .EXAMPLE
    # Get an EC2 instance by name
    Get-RscAwsNativeEc2Instance -Name "prod-api-server"

    .EXAMPLE
    # Get EC2 instances protected by a specific SLA
    Get-RscSla -Name "Gold" | Get-RscAwsNativeEc2Instance
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Id"
        )]
        [String]$Id,
        [Parameter(
            Position = 0,
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [String]$Name,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true,
            ParameterSetName = "Name"
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true,
            ParameterSetName = "Name"
        )]
        [RubrikSecurityCloud.Types.Cluster]$Cluster,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {

       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -Gql awsNativeEc2Instance
            $query.var.filter = @()
            $query.Var.fid = $Id

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -Gql awsNativeEc2Instances
            $query.var.ec2InstanceFilters = New-Object -TypeName RubrikSecurityCloud.Types.AwsNativeEc2InstanceFilters

            if ($Name) {
                $query.var.ec2InstanceFilters.nameOrIdSubstringFilter = New-Object RubrikSecurityCloud.Types.AwsNativeEc2InstanceNameOrIdSubstringFilter
                $query.var.ec2InstanceFilters.nameOrIdSubstringFilter.nameOrIdSubstring = $Name
            }
    
            if ($Sla) {
                $query.var.ec2InstanceFilters.effectiveSlaFilter = New-Object -TypeName RubrikSecurityCloud.Types.EffectiveSlaFilter
                $query.var.ec2InstanceFilters.effectiveSlaFilter.effectiveSlaIds = @($Sla.Id)
            }

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }





    } 
}

