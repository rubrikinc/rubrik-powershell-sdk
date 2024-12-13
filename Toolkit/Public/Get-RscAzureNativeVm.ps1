#Requires -Version 3
function Get-RscAzureNativeVm {
    <#
    .SYNOPSIS
    Retrieves RscAzureNativeVm objects protected by Rubrik Security Cloud

    .DESCRIPTION
    This cmdlet uses the GQL query 'azureNativeVirtualMachines' to retrieve a list of VMs with a predetermined set of properties.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get all
    Get-RscAzureNativeVm

    .EXAMPLE
    # Get object with specific name
    Get-RscAzureNativeVm -Name "jake-001"

    .EXAMPLE
    # Get objects by specifying part of a name
    Get-RscAzureNativeVm -Name "*jake*"
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
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [String]$NameSubstring,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true,
            ParameterSetName = "Name"
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla
    )
    
    Process {

       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -GqlQuery azureNativeVirtualMachine
            $query.var.filter = @()
            $query.Var.fid = $Id

            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -GqlQuery azureNativeVirtualMachines
            $query.var.filter = New-Object -TypeName RubrikSecurityCloud.Types.AzureNativeVirtualMachineFilters

            if ($NameSubstring) {
                $query.var.filter.nameSubstringFilter = New-Object -TypeName RubrikSecurityCloud.Types.NameSubstringFilter
                $query.var.filter.nameSubstringFilter.NameSubstring = $NameSubstring
            }
    
            if ($Sla) {
                $slaFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $slaFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::EFFECTIVE_SLA
                $slaFilter.Texts = $Sla.id
                $query.var.filter += $slaFilter
            }

            $result = Invoke-Rsc -Query $query
            $result.nodes
        }





    } 
}

