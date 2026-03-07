#Requires -Version 3
function Merge-RscPermission
{
    <#
    .SYNOPSIS
    Merges a permission into an RSC role.

    .DESCRIPTION
    Adds or updates a permission entry within an RSC role object. The permission
    is typically created with New-RscPermission and defines an operation and the
    objects it applies to. After merging, use Set-RscRole to save the updated role.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Permission
    A permission object, typically created with New-RscPermission.

    .PARAMETER Role
    A role object to merge the permission into. Pipe from Get-RscRole.

    .EXAMPLE
    # Create a permission and merge it into a role
    $perm = Get-RscSla "Gold" | Get-RscVmwareVm | New-RscPermission -Operation TAKE_ON_DEMAND_SNAPSHOT
    $role = Get-RscRole "myRole"
    Merge-RscPermission -Role $role -Permission $perm

    .EXAMPLE
    # Add snapshot permission for all workloads in an SLA
    $perm = Get-RscSla "Silver" | Get-RscWorkload | New-RscPermission -Operation TAKE_ON_DEMAND_SNAPSHOT
    Get-RscRole "BackupOps" | Merge-RscPermission -Permission $perm
    #>

    [CmdletBinding()]
    Param(
        # SLA Domain Duration
        [Parameter(ValueFromPipeline=$true,Mandatory=$true)]
        [RubrikSecurityCloud.Types.Permission]$Permission,

        [Parameter(ValueFromPipeline=$true,Mandatory=$true)]
        [RubrikSecurityCloud.Types.Role]$Role
    )
    Process {
        $operationIndex = $Role.permissions.findindex({ param($item) $item.Operation -eq $Permission.operation})
        Write-Verbose "Operation Index: $operationIndex"

        # If the permission Operation already exists in the role, then just add the additional Object Ids, otherwise add the new operation.
        if ($operationIndex -ne -1) {
            $roleObjectTypeIndex = $Role.permissions[$operationIndex].ObjectsForHierarchyTypes.findIndex({ param($item) $item.SnappableType -eq "ALL_SUB_HIERARCHY_TYPE"})
            Write-Verbose "Role Object Type Index (All Sub Hierarchy): $roleObjectTypeIndex"
            if ($roleObjectTypeIndex -ne -1) {
                $Role.permissions[$operationIndex].ObjectsForHierarchyTypes[$roleObjectTypeIndex].ObjectIds += $permission.ObjectsForHierarchyTypes[$permission.ObjectsForHierarchyTypes.findIndex({ param($item) $item.SnappableType -eq "ALL_SUB_HIERARCHY_TYPE"})].ObjectIds
            }
        }
        else {
            $Role.permissions += $Permission
        }
        $Role
    }
}
