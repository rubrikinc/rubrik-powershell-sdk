# Invoke-RscMutateSnappable
## Subcommands
### Assignretentionslato
- There are 6 arguments.
    - globalSlaOptionalFid - System.String: Global SLA Domain forever UUID.
    - globalSlaAssignType - SlaAssignTypeEnum: Corresponds to the assignment type for the global SLA
    - objectIds - list of System.Strings: A list of object forever UUIDs to assign to the global SLA Domain.
    - applicableSnappableType - WorkloadLevelHierarchy: Provide optional snappable type under the object for SLA assignment. This is meant to be used only for objects that support multiple snappable hierarchies. This allows an SLA to be set for one/more specific snappable types under the object, instead of applying the SLA for all the snappable types. For example, an AWS account object can potentially have 2 different snappable types under it - AwsNativeEc2Instance and AwsNativeRdsInstance. This field can be set with the appropriate type so that the SLA only gets applied to snappables of the selected type under that account. If the SLA must be applicable for all the snappable types under the object, then this field can be set to `AllSubHierarchyType` or left blank. This field must either be left blank or set to `AllSubHierarchyType` when assigning SLA to a snappable or to an object that does not support multiple snappable types.
    - shouldApplyToNonPolicySnapshots - System.Boolean: Boolean value to indicate if the new configuration keeps existing, non-policy snapshots of data sources retained by this SLA Domain.
    - userNote - System.String: Optional User note.
- Returns SlaAssignResult.
### Assignslasforhierarchie
- There are 8 arguments.
    - globalSlaOptionalFid - System.String: Global SLA Domain forever UUID.
    - globalSlaAssignType - SlaAssignTypeEnum: Corresponds to the assignment type for the global SLA
    - objectIds - list of System.Strings: A list of object forever UUIDs to assign to the global SLA Domain.
    - applicableSnappableTypes - list of WorkloadLevelHierarchys: Provide optional snappable types under the object for SLA assignment. This is meant to be used only for objects that support multiple snappable hierarchies. See 'applicableSnappableType' for more details. If more than one is provided, the SLA will be assigned to all.
    - shouldApplyToExistingSnapshots - System.Boolean: Boolean value to indicate whether to apply changes made to the SLA to existing snapshots.
    - shouldApplyToNonPolicySnapshots - System.Boolean: Boolean value to indicate if the new configuration keeps existing, non-policy snapshots of data sources retained by this SLA Domain.
    - globalExistingSnapshotRetention - GlobalExistingSnapshotRetention: Choose what to do with existing snapshot in case of do not protect slas
    - userNote - System.String: Optional User note.
- Returns list of SlaAssignResults.
