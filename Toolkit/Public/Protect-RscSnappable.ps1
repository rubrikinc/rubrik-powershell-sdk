#Requires -Version 3
function Protect-RscSnappable
{
  <#
    .SYNOPSIS
    Assigns a Rubrik Security Cloud Snappable (an object that can be snapshotted) to an SLA.

    .DESCRIPTION
    Protecting workloads is a fundemental capability of Rubrik Security Cloud. This cmdlet accepts any RSC 'snappable' object and assigns it to an SLA.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Assign a VM named "foo" to the Gold SLA
    
    Get-RscVmwareVm -Name "Foo" | Protect-RscSnappable -Sla (Get-RscSla -Name "Gold")

    .EXAMPLE
    Bulk SLA assignment will pass all objects in with the same API call, greatly increasing performance.
    
    Protect-RscSnappable -InputObject (Get-RscVmwareVm) -Sla (Get-RscSla -Name "Gold")

    .EXAMPLE
    Set VM to DO NOT PROTECT
    
    Get-RscVmwareVm -Name "Foo" | Protect-RscSnappable -AssignmentType doNotProtect

    .EXAMPLE
    Remove SLA Assignment from a VM
    
    Get-RscVmwareVm -Name "Foo" | Protect-RscSnappable -AssignmentType noAssignment
  #>

  [CmdletBinding()]
  Param(
    # Id of a snappable to be assigned
    [Parameter(ValueFromPipelineByPropertyName=$true)]
    [String]$Id,

    # Input object that accepts an array of objects for bulk assignment
    [Parameter()]
    $InputObject,

    # RSC Sla Object
    [Parameter()]
    [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,

    # RSC Sla Object
    [Parameter()]
    [RubrikSecurityCloud.Types.SlaAssignTypeEnum]$AssignmentType = [RubrikSecurityCloud.Types.SlaAssignTypeEnum]::PROTECT_WITH_SLA_ID,
  
    # RSC Sla Object
    [Parameter()]
    [Switch]$ShouldApplyToExistingSnapshots,

    # RSC Sla Object
    [Parameter()]
    [Switch]$ShouldApplyToNonPolicySnapshots,

    # RSC Sla Object
    [Parameter()]
    [RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]$ExistingSnapshotAction
  )
    Process {

        $query = New-RscMutation -GqlMutation assignSla
        $query.Var.Input = New-Object -TypeName RubrikSecurityCloud.Types.AssignSlaInput
        $query.Var.Input.slaDomainAssignType = $AssignmentType
        $query.Var.Input.existingSnapshotRetention = $ExistingSnapshotAction

        if ($Id) {
          $query.Var.Input.ObjectIds = @($Id)
        }
        elseif ($InputObject) {
          $query.Var.Input.ObjectIds = $InputObject.id
        }

        if ($Sla) {
          $query.Var.Input.slaOptionalId = $Sla.Id
        }

        if ($ShouldApplyToExistingSnapshots) {
          $query.Var.Input.ShouldApplyToExistingSnapshots = "true"
        }

        if ($ShouldApplyToNonPolicySnapshots) {
          $query.Var.Input.ShouldApplyToNonPolicySnapshots = "true"
        }
        
        $result = Invoke-Rsc -Query $query
        $result
    }
} 
