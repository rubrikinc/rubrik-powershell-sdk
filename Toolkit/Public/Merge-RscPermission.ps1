#Requires -Version 3
function Merge-RscPermission
{
    <#
    .SYNOPSIS
    Merges a Rubrik Permission into a Role

    .DESCRIPTION
    The Merge-RscPermission command takes a RubrikSecurityCloud permission object and merges into a RubrikSecurityCloud Role

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference



    .EXAMPLE
    # Create permission object to take on-demand snapshot of all VMs in the Gold SLA, then merge into a role.
    $permission = Get-RscSla -name "Gold" | Get-RscVmwareVm | New-RscPermission -Operation TAKE_ON_DEMAND_SNAPSHOT
    $role = Get-RscRole "myRole"
    Merge-RscPermission -Role $role -Permission $permission

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
