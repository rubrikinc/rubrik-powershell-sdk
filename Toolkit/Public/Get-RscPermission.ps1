#Requires -Version 3
function Get-RscPermission
{
    <#
    .SYNOPSIS
    Retrieves permissions defined within an RSC role.

    .DESCRIPTION
    Returns the permissions that make up an RSC role. Each permission defines an
    operation and a set of objects that the operation can be performed on. Use
    -Operation to filter to a specific permission. The output can be modified and
    merged back into a role using Merge-RscPermission.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Operation
    Filter to a specific operation type (e.g., TAKE_ON_DEMAND_SNAPSHOT).

    .PARAMETER Role
    A role object to retrieve permissions from. Pipe from Get-RscRole.

    .EXAMPLE
    # Get all permissions for a role
    Get-RscRole "Admin" | Get-RscPermission

    .EXAMPLE
    # Get a specific permission from a role
    $perm = Get-RscRole "BackupAdmin" | Get-RscPermission -Operation TAKE_ON_DEMAND_SNAPSHOT
    #>

    [CmdletBinding()]
    Param(

        [Parameter(Mandatory=$false)]
        [RubrikSecurityCloud.Types.Operation]$Operation,

        [Parameter(ValueFromPipeline=$true, Mandatory=$true)]
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
