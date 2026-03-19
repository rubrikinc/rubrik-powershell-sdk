#Requires -Version 3
function Protect-RscLinkedWorkload
{
  <#
    .SYNOPSIS
    Links workloads across Rubrik clusters and assigns an SLA Domain.

    .DESCRIPTION
    Manages linked protection for workloads that span multiple Rubrik clusters, such as SQL Server Always On Availability Groups. You can link two workload objects together and assign them a shared SLA Domain, assign an SLA to already-linked objects, or unlink them. Both objects must be the same workload type. Only one pair can be linked per call; use a loop for multiple pairs.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER MssqlLogConfigFromSla
    For MSSQL workloads: after linking and assigning the SLA, automatically
    set the database to inherit its log backup configuration from the SLA Domain
    (equivalent to the RSC UI option "Follow the log configuration in the SLA Domain").
    This fires a follow-up assignMssqlSlaDomainPropertiesAsync mutation.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Link two Availability Groups across clusters and assign an SLA.

    $ag1 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" -Cluster (Get-RscCluster -Name "Bar") -Relic:$false -Replica:$false
    $ag2 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" -Cluster (Get-RscCluster -Name "Baz") -Relic:$false -Replica:$false
    Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 -LinkingOperation LINK -AssignmentType PROTECT_WITH_SLA_ID -Sla (Get-RscSla -Name "Bronze")

    .EXAMPLE
    Unlink two previously linked workloads.

    Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 -LinkingOperation UNLINK -AssignmentType PROTECT_WITH_SLA_ID

    .EXAMPLE
    Link two AGs and use the SLA Domain's log backup configuration:

    $ag1 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" -Cluster (Get-RscCluster -Name "Bar") -Relic:$false -Replica:$false
    $ag2 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" -Cluster (Get-RscCluster -Name "Baz") -Relic:$false -Replica:$false
    Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 -LinkingOperation LINK -AssignmentType PROTECT_WITH_SLA_ID -Sla (Get-RscSla -Name "Bronze") -MssqlLogConfigFromSla

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

    # For MSSQL workloads: inherit log backup configuration from the SLA Domain
    [Parameter()]
    [switch]$MssqlLogConfigFromSla,

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
            $query = New-RscMutation -Gql manageProtectionForLinkedObjects
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
            
            # Validate early: -MssqlLogConfigFromSla requires -Sla
            if ($MssqlLogConfigFromSla -and -not $Sla) {
              throw "-MssqlLogConfigFromSla requires -Sla to be specified."
            }

            if ($AsQuery.IsPresent) {
              if ($MssqlLogConfigFromSla) {
                Write-Warning "-AsQuery returns the primary query only. The -MssqlLogConfigFromSla follow-up mutation is not included."
              }
              return $query
            }
            else {
              $result = $query.invoke()

              # Follow-up: set MSSQL log config to inherit from SLA Domain
              if ($MssqlLogConfigFromSla) {
                $mssqlQuery = New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync
                $mssqlQuery.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
                $mssqlQuery.Var.input.userNote = ""
                $mssqlQuery.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
                $mssqlQuery.Var.input.updateinfo.ids = @($InputObjects[0].id, $LinkedObject.id)
                $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
                $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.configuredSLADomainId = $Sla.Id
                $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaRelatedPropertiesInput
                $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla = $true
                $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = -1
                try {
                  $mssqlQuery.invoke() | Out-Null
                } catch {
                  Write-Warning "SLA assigned successfully, but failed to set MSSQL log config from SLA: $_"
                }
              }

              return $result
            }

          }
        }
      }
    }
} 
