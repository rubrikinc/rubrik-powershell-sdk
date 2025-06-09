#Requires -Version 3
function Protect-RscLinkedWorkload
{
  <#
    .SYNOPSIS
    Creates linked workloads and assigns an SLA.

    .DESCRIPTION
    This cmdlet performs linking and SLA assignment operations for workloads such as a MSSQL availability groups that are spread across multiple Rubrik Clusters.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    $ag1 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" -Cluster (Get-RscCluster -Name "Bar") -Relic:$false -Replica:$false
    $ag2 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" -Cluster (Get-RscCluster -Name "Baz") -Relic:$false -Replica:$false
    Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 -LinkingOperation LINK -AssignmentType PROTECT_WITH_SLA_ID -Sla (Get-RscSla -Name "Bronze")
    
  #>

  [CmdletBinding()]
  Param(

    # Input object that accepts an array of objects for bulk assignment
    [Parameter(ValueFromPipeline=$true,Mandatory=$true)]
    [RubrikSecurityCloud.Types.BaseType]$InputObject,

    # RSC Sla Object
    [Parameter()]
    [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,

    # RSC Assignment Type
    [Parameter(Mandatory=$true)]
    [RubrikSecurityCloud.Types.SlaAssignTypeEnum]$AssignmentType = [RubrikSecurityCloud.Types.SlaAssignTypeEnum]::PROTECT_WITH_SLA_ID,
  
    # RSC Apply to existing snapshots
    [Parameter()]
    [Switch]$ShouldApplyToExistingSnapshots,

    # RSC Apply to non-policy snapshots
    [Parameter()]
    [Switch]$ShouldApplyToNonPolicySnapshots,

    # RSC Snapshot retention setting
    [Parameter()]
    [RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]$ExistingSnapshotAction,

    # RSC Object to be linked
    [Parameter(Mandatory=$true)]
    [RubrikSecurityCloud.Types.BaseType]$LinkedObject,
    
    # Linking Operation (LINK (and assign SLA), ASSIGN_SLA, UNLINK)
    [Parameter(Mandatory=$true)]
    [RubrikSecurityCloud.Types.ManageProtectionForLinkedObjectsOperationType]$LinkingOperation,

    # Returns API query
    [Parameter()]
    [switch]$AsQuery
  )
    Begin {
      $InputObjects = @()
    }

    Process {
      ### If user is using the LinkedObject parameter, this is needs to go to the manageProtectionForLinkedObjects. 
      ### We cannot do assignment and linking in Process{} because we need to make sure they don't pipe in multipe objects.
      ### We add them up in End{} and make sure there's only 1 piped object.
      $InputObjects += $InputObject
    }

    End {
      if($LinkedObject) {
        ### The manageProtectionForLinkedObjects mutation accepts an array, but only 2 objects can be linked. 
        ### We need to make sure the user doesn't pipe in multiple objects.
        if ($InputObjects.count -gt 1) {
          throw "Pipeline received multiple objects. Linking objects requires single input object and single linked object. Use a for-loop for linking multiple pairs."
        }
        else {
          ### We need to check to see if the objects are already linked. This determines the operation: LINK, UNLINK, ASSIGN_SLA.
          ### Do we put in an additional argument for unlink here? Do we just give them all 3 options in a parameterset parameter called -LinkingOperation?
          ### Make sure the object types are the same. 
          if ($InputObjects[0].GetType() -ne $LinkedObject.GetType()){
            throw "InputObject and LinkedObject must be the same type. InputObject: $($InputObjects[0].GetType().FullName) != $($LinkedObject.GetType().FullName)"
          }
          else {
            $query = New-RscMutation -GqlMutation manageProtectionForLinkedObjects
            $query.Var.input = Get-RscType -Name ManageProtectionForLinkedObjectsInput
            $query.var.input.operation = $LinkingOperation
            $query.Var.input.AssignSlaReq = Get-RscType -Name AssignSlaInput
            $query.Var.input.AssignSlaReq.ObjectIds = @($InputObjects[0].id, $LinkedObject.id)
            
            if ($Sla) {
              $query.Var.Input.AssignSlaReq.slaOptionalId = $Sla.Id
            }

            if ($AssignmentType) {
              $query.var.input.AssignSlaReq.slaDomainAssignType = $AssignmentType
            }
    
            if ($ShouldApplyToExistingSnapshots) {
              $query.Var.Input.AssignSlaReq.ShouldApplyToExistingSnapshots = "true"
            }
    
            if ($ShouldApplyToNonPolicySnapshots) {
              $query.Var.Input.AssignSlaReq.ShouldApplyToNonPolicySnapshots = "true"
            }
            
            if ($AsQuery.IsPresent) {
              return $query
            }
            else {
              $result = $query.invoke()
              return $result
            }

          }
        }
      }
    }
} 
