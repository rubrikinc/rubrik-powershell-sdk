#Requires -Version 3
function Get-RscAzureNativeVm {
    <#
    .SYNOPSIS
    Retrieves Azure native virtual machines managed by Rubrik Security Cloud.

    .DESCRIPTION
    Returns Azure native VMs that are protected or inventoried by Rubrik. You can
    filter by name substring or SLA Domain. Use -Id to retrieve a single VM
    by its RSC identifier.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Id
    The RSC object ID.

    .PARAMETER NameSubstring
    Filter by name. Matches VMs whose name contains the specified string.

    .PARAMETER Sla
    An SLA Domain object to filter by. Pipe from Get-RscSla.

    .EXAMPLE
    # Get all Azure native VMs
    Get-RscAzureNativeVm

    .EXAMPLE
    # Get Azure VMs matching a name substring
    Get-RscAzureNativeVm -NameSubstring "prod"

    .EXAMPLE
    # Get Azure VMs protected by a specific SLA
    Get-RscSla -Name "Gold" | Get-RscAzureNativeVm
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
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {

       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -Gql azureNativeVirtualMachine
            $query.Var.azureVirtualMachineRubrikId = $Id

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -Gql azureNativeVirtualMachines
            $query.var.virtualMachineFilters = (New-Object -TypeName RubrikSecurityCloud.Types.AzureNativeVirtualMachineFilters)

            if ($NameSubstring) {          
                $query.var.virtualMachineFilters.nameSubstringFilter = New-Object -TypeName RubrikSecurityCloud.Types.NameSubstringFilter
                $query.var.virtualMachineFilters.nameSubstringFilter.NameSubstring = $NameSubstring
            }
    
            if ($Sla) {
                $query.var.virtualMachineFilters.effectiveSlaFilter =  (New-Object -TypeName RubrikSecurityCloud.Types.EffectiveSlaFilter)
                $query.var.virtualMachineFilters.effectiveSlaFilter.effectiveSlaIds = @($Sla.id)
            }

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }





    } 
}

