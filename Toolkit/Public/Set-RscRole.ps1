#Requires -Version 3
function Set-RscRole
{
  <#
    .SYNOPSIS
    Creates or updates a role in Rubrik Security Cloud.

    .DESCRIPTION
    Saves a role object to RSC. If the role has an Id, the existing role is updated; if the Id is null, a new role is created. Use Get-RscRole to retrieve a role, modify its properties (Name, Description, Permissions), and pipe it to this cmdlet. You can also use Merge-RscPermission to add permissions before saving.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Role
    The role object to create or update. Accepts pipeline input from Get-RscRole.

    .EXAMPLE
    Update the description of a role.

    $role = Get-RscRole "foo"
    $role.Description = "Updated description"
    $role | Set-RscRole

    .EXAMPLE
    Create a new role by copying an existing one.

    $role = Get-RscRole "foo"
    $role.Name = "bar"
    $role.Id = $null
    $role | Set-RscRole

    .EXAMPLE
    Add snapshot permissions for Gold SLA VMs to a role.

    $permission = Get-RscSla -Name "Gold" | Get-RscVmwareVm | New-RscPermission -Operation TAKE_ON_DEMAND_SNAPSHOT
    $role = Get-RscRole "myRole"
    $newRole = Merge-RscPermission -Role $role -Permission $permission
    $newRole | Set-RscRole
  #>

  [CmdletBinding()]
  Param(

    # RSC Sla Object
    [Parameter(ValueFromPipeline=$true)]
    [RubrikSecurityCloud.Types.Role]$Role,

    [Parameter(
        Mandatory = $false,
        ValueFromPipeline = $false,
        HelpMessage = "Return the query object instead of running the query"
    )][Switch]$AsQuery

  )
    Process {
        $query = New-RscMutation -Gql mutateRole
        if ($Role.Id) {
          $query.Var.roleId = $Role.Id
        }
        $query.Var.name = $Role.Name
        $query.Var.description = $Role.Description
        $query.Var.permissions = $Role.Permissions
        $query.Var.protectableClusters = $role.ProtectableClusters
        
        if ( $AsQuery ) { return $query }
        $result = Invoke-Rsc -Query $query
        $result
    }
} 
