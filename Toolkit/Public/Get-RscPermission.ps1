#Requires -Version 3
function Get-RscPermission
{
    <#
    .SYNOPSIS
    Lists permissions inside an RSC Role

    .DESCRIPTION
    An RSC Permission is a component of a role that defines an operation and a set of objects that operation can be performed.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get all permissions for a role
    Get-RscRole "foo" | Get-RscPermission

    .EXAMPLE
    # Get specific permission for a role, which can then be edited and then merged back into the role.
    $permission = Get-RscRole "foo" | Get-RscPermission -Operation TAKE_ON_DEMAND_SNAPSHOT

    #>

    [CmdletBinding()]
    Param(
        # SLA Domain Duration
        [Parameter(ValueFromPipeline=$true,Mandatory=$true)]
        [RubrikSecurityCloud.Types.Operation]$Operation,

        [Parameter(ValueFromPipeline=$true)]
        [RubrikSecurityCloud.Types.Role]$Role
    )
    Process {
        if ($Operation) {
            $operationIndex = $Role.permissions.findindex({ param($item) $item.Operation -eq $Operation})
            if ($operationIndex -ne -1) {
                $Role.Permissions[$operationIndex]
            }
        }
        else {
            $Role.Permissions
        }
    }
}
