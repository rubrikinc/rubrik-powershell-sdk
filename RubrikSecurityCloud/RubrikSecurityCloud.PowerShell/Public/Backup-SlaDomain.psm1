#Requires -Version 3
function Backup-SlaDomain
{
  <#  
      .SYNOPSIS
      Assign an SLA domain to a workload.
            
      .DESCRIPTION
      The Backup-SlaDomain cmdlet will assign an SLA to a workload.

      .NOTES
            
      .LINK
            
      .EXAMPLE
      Backup-SlaDomain -SlaDomainAssignType "PROTECT_WITH_SLA_ID" -SlaOptionalId "00000000-0000-0000-0000-000000000000" -ObjectIds @("31012362-0ca8-5536-8c1a-313d756396c3")
      
      This will assign a Gold SLA to the object with ID 31012362-0ca8-5536-8c1a-313d756396c3.
  #>

  [CmdletBinding()]
  Param(
    # Corresponds to the assignment type for the SLA Domain.
    [Parameter(
      Mandatory = $true, 
      ValueFromPipelineByPropertyName = $true
    )]
    [Rubrik.SecurityCloud.Types.SlaAssignTypeEnum]$SlaDomainAssignType,
    # Corresponds to optional SLA Domain ID.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [string]$SlaOptionalId,
    # Provide list of object IDs you want to assign SLA Domain.
    [Parameter(
      Mandatory = $true, 
      ValueFromPipelineByPropertyName = $true
    )]
    [string[]]$ObjectIds,
    # Provide optional workload type under the object for SLA Domain assignment. This is meant to be used only for objects that support multiple workload hierarchies. This allows an SLA Domain to be set for one or more specific workload types under the object, instead of applying the SLA Domain for all the workload types. For example, an AWS account object can potentially have 2 different workload types under it - AwsNativeEc2Instance and AwsNativeRdsInstance. This field can be set with the appropriate type so that the SLA Domain only gets applied to workloads of the selected type under that account. If the SLA Domain must be applicable for all the workload types under the object, then this field can be set to `AllSubHierarchyType` or left blank. This field must either be left blank or set to `AllSubHierarchyType` when assigning SLA Domain to a workload or to an object that does not support multiple workload types.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [Rubrik.SecurityCloud.Types.WorkloadLevelHierarchy]$ApplicableWorkloadType,
    # Boolean value to indicate whether to apply changes made to the SLA Domain to existing snapshots.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [bool]$ShouldApplyToExistingSnapshots,
    # Boolean value to indicate if the new configuration keeps existing, non-policy snapshots of data sources retained by this SLA Domain.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [bool]$ShouldApplyToNonPolicySnapshots,
    # Choose what to do with existing snapshot in case of do not protect SLA Domains.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [Rubrik.SecurityCloud.Types.GlobalExistingSnapshotRetention]$ExistingSnapshotRetention,
    # Optional User note.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [string]$UserNote
  )

    Begin {

    # -1- Re-use existing connection, or create a new one:
    Connect-Rsc -ErrorAction Stop | Out-Null

    # -2- Retrieve pre-defined operation
    $operation = "assign"  
  }

  Process {
    $inputs = Invoke-RscMutateSla -Op $operation -InputProfile "Detail" -GetInputs

    # -3- Customize inputs
    $inputValues = @{
      "slaDomainAssignType" = $SlaDomainAssignType
      "slaOptionalId" = $SlaOptionalId
      "objectIds" = $ObjectIds
      "applicableWorkloadType" = $ApplicableWorkloadType
      "shouldApplyToExistingSnapshots" = $ShouldApplyToExistingSnapshots
      "shouldApplyToNonPolicySnapshots" = $ShouldApplyToNonPolicySnapshots
      "existingSnapshotRetention" = $ExistingSnapshotRetention
      "userNote" = $UserNote
    }

    $inputs.Arg.input = $inputValues

    return Invoke-RscMutateSla -Op $operation -Arg $inputs.Arg -Field $inputs.Field
  }
}
