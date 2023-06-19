### AssignSlaInput
Input to assign Rubrik SLA Domains.

- slaDomainAssignType: SlaAssignTypeEnum
  - Corresponds to the assignment type for the SLA Domain.
- slaOptionalId: System.String
  - Corresponds to optional SLA Domain ID.
- objectIds: list of System.Strings
  - Provide list of object IDs you want to assign SLA Domain.
- applicableWorkloadType: WorkloadLevelHierarchy
  - Provide optional workload type under the object for SLA Domain assignment. This is meant to be used only for objects that support multiple workload hierarchies. This allows an SLA Domain to be set for one or more specific workload types under the object, instead of applying the SLA Domain for all the workload types. For example, an AWS account object can potentially have 2 different workload types under it - AwsNativeEc2Instance and AwsNativeRdsInstance. This field can be set with the appropriate type so that the SLA Domain only gets applied to workloads of the selected type under that account. If the SLA Domain must be applicable for all the workload types under the object, then this field can be set to `AllSubHierarchyType` or left blank. This field must either be left blank or set to `AllSubHierarchyType` when assigning SLA Domain to a workload or to an object that does not support multiple workload types.
- shouldApplyToExistingSnapshots: System.Boolean
  - Boolean value to indicate whether to apply changes made to the SLA Domain to existing snapshots.
- shouldApplyToNonPolicySnapshots: System.Boolean
  - Boolean value to indicate if the new configuration keeps existing, non-policy snapshots of data sources retained by this SLA Domain.
- existingSnapshotRetention: GlobalExistingSnapshotRetention
  - Choose what to do with existing snapshot in case of do not protect SLA Domains.
- userNote: System.String
  - Optional User note.
