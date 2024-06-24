#Requires -Version 3
function Set-RscRole
{
  <#
    .SYNOPSIS
    Updates an RSC Role.

    .DESCRIPTION
    RSC Roles are a collection of permissions and objects. This cmdlet overwrites the existing role with another role object.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Update the description of a role
    
    $role = Get-RscRole "foo"
    $role.Description = "Test Role"
    $role | Set-RscRole

    .EXAMPLE
    # Copy a Role into a new role
    $role = Get-RscRole "foo"
    $role.Name = "bar"
    $role.Id = $null
    $role | Set-RscRole

    .EXAMPLE
    # Create permission object to take on-demand snapshot of all VMs in the Gold SLA, merge into a new Role object, and update the role in RSC.
    $permission = Get-RscSla -name "Gold" | Get-RscVmwareVm | New-RscPermission -Operation TAKE_ON_DEMAND_SNAPSHOT
    $role = Get-RscRole "myRole"
    $newRole = Merge-RscPermission -Role $role -Permission $permission
    $newRole | Set-RscRole
  #>

  [CmdletBinding()]
  Param(

    # RSC Sla Object
    [Parameter(ValueFromPipeline=$true)]
    [RubrikSecurityCloud.Types.Role]$Role

  )
    Process {
        $query = New-RscMutation -GqlMutation mutateRole
        if ($Role.Id) {
          $query.Var.roleId = $Role.Id
        }
        $query.Var.name = $Role.Name
        $query.Var.description = $Role.Description
        $query.Var.permissions = $Role.Permissions
        $query.Var.protectableClusters = $role.ProtectableClusters
        
        $result = Invoke-Rsc -Query $query
        $result
    }
} 
