#Requires -Version 3
function Get-RscRole {
    <#
    .SYNOPSIS
    Retrieves Roles defined in Rubrik Security Cloud

    .DESCRIPTION
    Rubrik Security Cloud Roles define a set of permissions that can be assigned to specific users or service accounts. 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get all roles
    Get-RscRole

    .EXAMPLE
    # Get role with specific name
    Get-RscRole -Name "Admin"
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Id"
        )]
        [String[]]$Id,
        [Parameter(
            Position = 0,
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [String]$Name,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -GqlQuery getRolesByIds -FieldProfile FULL
            $query.var.roleIds = $Id
            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -GqlQuery getAllRolesInOrgConnection -FieldProfile FULL
            if ($Name) {
                $query.var.nameFilter = $Name
            }
            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }
    }
}
