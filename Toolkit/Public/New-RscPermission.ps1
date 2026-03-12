#Requires -Version 3
function New-RscPermission
{
    <#
    .SYNOPSIS
    Creates a new permission object for use in an RSC role.

    .DESCRIPTION
    Builds a permission object that defines an operation and the set of objects it
    applies to. Pipe workload objects to this cmdlet to scope the permission to
    those objects. The resulting permission is passed to Merge-RscPermission to
    add it to a role.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Operation
    The operation type for this permission (e.g., TAKE_ON_DEMAND_SNAPSHOT).

    .PARAMETER InputObject
    One or more workload objects to scope the permission to. Pipe from any Get-Rsc* cmdlet.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Create a permission for on-demand snapshots of VMs in the Gold SLA
    $perm = Get-RscSla "Gold" | Get-RscVmwareVm | New-RscPermission -Operation TAKE_ON_DEMAND_SNAPSHOT
    Merge-RscPermission -Role (Get-RscRole "myRole") -Permission $perm

    .EXAMPLE
    # Create a permission for all workloads
    $perm = Get-RscWorkload | New-RscPermission -Operation VIEW_INVENTORY
    #>

    [CmdletBinding()]
    Param(
        # SLA Domain Duration
        [Parameter(Mandatory=$true)]
        [RubrikSecurityCloud.Types.Operation]$Operation,

        [Parameter(ValueFromPipeline=$true)]
        [RubrikSecurityCloud.Types.BaseType[]]$InputObject,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
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
        $globalResourceQuery = New-RscQuery -Gql allAuthorizationsForGlobalResource
        if ( $AsQuery ) { return $globalResourceQuery }
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
