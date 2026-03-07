#Requires -Version 3
function Get-RscRole {
    <#
    .SYNOPSIS
    Retrieves roles defined in Rubrik Security Cloud.

    .DESCRIPTION
    Returns RSC roles, which define sets of permissions that can be assigned to
    users or service accounts. Use -Name to filter by role name or -Id to
    retrieve specific roles. Pipe the output to Get-RscPermission to inspect
    the permissions within a role.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Id
    One or more RSC role IDs.

    .PARAMETER Name
    Filter by name. Matches roles whose name contains the specified string.

    .EXAMPLE
    # Get all roles
    Get-RscRole

    .EXAMPLE
    # Get a role by name and inspect its permissions
    Get-RscRole -Name "Admin" | Get-RscPermission
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
            $query = New-RscQuery -Gql getRolesByIds -FieldProfile FULL
            $query.var.roleIds = $Id
            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -Gql getAllRolesInOrgConnection -FieldProfile FULL
            if ($Name) {
                $query.var.nameFilter = $Name
            }
            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }
    }
}
