#Requires -Version 3
function New-RscPermission
{
    <#
    .SYNOPSIS
    Creates a new Rubrik role permission

    .DESCRIPTION
    The New-RscPermission creates a new permission for use inside of a role.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference



    .EXAMPLE
    # Create permission object to take on-demand snapshot of all VMs in the Gold SLA, then merge into a role.
    $permission = Get-RscSla -name "Gold" | Get-RscVmwareVm | New-RscPermission -Operation TAKE_ON_DEMAND_SNAPSHOT
    $role = Get-RscRole "myRole"
    Merge-RscPermission -Role $role -Permission $permission

    .EXAMPLE
    New-RscPermission
    #>

    [CmdletBinding()]
    Param(
        # SLA Domain Duration
        [Parameter(Mandatory=$true)]
        [RubrikSecurityCloud.Types.Operation]$Operation,

        [Parameter(ValueFromPipeline=$true)]
        [RubrikSecurityCloud.Types.BaseType[]]$InputObject
    )
    Begin {
        $objectIds = @()
    }
    Process {
        # Use the fid if available. Sometimes Id refers to the CDM ID (e.g. snappableConnection/Get-RscWorkload)
        foreach ($obj in $InputObject) {
            if ($obj.gettype().GetProperty("Fid")) {
                $objectIds += $obj.id
            }
            else {
                $objectIds += $obj.id
            }
        }
    }
    End {
        $globalResourceQuery = New-RscQuery -GqlQuery allAuthorizationsForGlobalResource
        $globalResourceOperations = Invoke-Rsc $globalResourceQuery

        $permission = New-Object -TypeName RubrikSecurityCloud.Types.Permission
        $permission.Operation = $Operation
        $idsForSubHierarchy = New-Object -TypeName RubrikSecurityCloud.Types.ObjectIdsForHierarchyType

        # Do we need a conditional here to figure out if it's one of the enum values here, or can we just always use all_sub?
        # It's confusing because the only things in the enum are cloud related.
        $idsForSubHierarchy.SnappableType = [RubrikSecurityCloud.Types.WorkloadLevelHierarchy]::ALL_SUB_HIERARCHY_TYPE

        # TODO: If the operation pertains to a global resource, we need to ignore the input object and add the ObjectId of "GlobalResource".
        # Might also want to think about all the _ROOT stuff at the same time. For now, we only support individual IDs.
        # Would be nice if these were enums in the API.
        if ($globalResourceOperations -contains $Operation) {
            $idsForSubHierarchy.ObjectIds = "GlobalResource"
        }
        else {
            $idsForSubHierarchy.ObjectIds = $objectIds
        }


        $permission.ObjectsForHierarchyTypes = $idsForSubHierarchy
        $permission
    }
}
