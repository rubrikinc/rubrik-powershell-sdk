### AssignSlasForWorkloadHierarchiesInput
Input to assign Rubrik SLA Domains.

- slaDomainAssignType: SlaAssignTypeEnum
  - SLA Domain assignment type.
- slaOptionalId: System.String
  - Optional SLA Domain ID.
- objectIds: list of System.Strings
  - List of object IDs you want to assign to the SLA Domain.
- applicableWorkloadTypes: list of WorkloadLevelHierarchys
  - Provide optional workload types under the object for SLA Domain assignment. This is meant to be used only for objects that support multiple workload hierarchies. This allows an SLA Domain to be set for one or more specific workload types under the object, instead of applying the SLA Domain for all the workload types. For example, an AWS account object can potentially have 2 different workload types under it - AwsNativeEc2Instance and AwsNativeRdsInstance. This field can be set with the appropriate types so that the SLA Domain only gets applied to workloads of the selected types under that account. If the SLA Domain must be applicable for all the workload types under the object, then this field can be set to [`AllSubHierarchyType`] or left blank. This field must either be left blank or set to [`AllSubHierarchyType`] when assigning SLA Domain to a workload or to an object that does not support multiple workload types.
- shouldApplyToExistingSnapshots: System.Boolean
  - Specifies whether to apply the SLA Domain changes to the existing snapshots.
- shouldApplyToNonPolicySnapshots: System.Boolean
  - Specifies whether to retain existing on-demand snapshots for workloads to which this SLA Domain is assigned.
- existingSnapshotRetention: GlobalExistingSnapshotRetention
  - Represents the behavior for existing snapshots when Do Not Protect option is selected.
