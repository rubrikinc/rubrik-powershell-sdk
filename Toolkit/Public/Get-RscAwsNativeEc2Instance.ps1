#Requires -Version 3
function Get-RscAwsNativeEc2Instance {
    <#
    .SYNOPSIS
    Retrieves RscAwsNativeEc2Instance objects protected by Rubrik Security Cloud

    .DESCRIPTION
    This cmdlet uses the GQL query 'awsNativeEc2Instances' to retrieve a list of VMs with a predetermined set of properties.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get all
    Get-RscAwsNativeEc2Instance

    .EXAMPLE
    # Get object with specific name
    Get-RscAwsNativeEc2Instance -Name "jake-001"

    .EXAMPLE
    # Get objects by specifying part of a name
    Get-RscAwsNativeEc2Instance -Name "*jake*"
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
            $query = New-RscQuery -GqlQuery awsNativeEc2Instance
            $query.var.filter = @()
            $query.Var.fid = $Id

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -GqlQuery awsNativeEc2Instances
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

