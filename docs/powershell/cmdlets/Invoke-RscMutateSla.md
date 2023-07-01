# Invoke-RscMutateSla
## Subcommands
### assign
Endpoint to assign SLA Domain.

- There is a single argument of type AssignSlaInput.
- Returns SlaAssignResult.
### assignretentiontosnappable
- There are 6 arguments.
    - globalSlaOptionalFid - System.String: Global SLA Domain forever UUID.
    - globalSlaAssignType - SlaAssignTypeEnum: Corresponds to the assignment type for the global SLA
    - objectIds - list of System.Strings: A list of object forever UUIDs to assign to the global SLA Domain.
    - applicableSnappableType - WorkloadLevelHierarchy: Provide optional snappable type under the object for SLA assignment. This is meant to be used only for objects that support multiple snappable hierarchies. This allows an SLA to be set for one/more specific snappable types under the object, instead of applying the SLA for all the snappable types. For example, an AWS account object can potentially have 2 different snappable types under it - AwsNativeEc2Instance and AwsNativeRdsInstance. This field can be set with the appropriate type so that the SLA only gets applied to snappables of the selected type under that account. If the SLA must be applicable for all the snappable types under the object, then this field can be set to `AllSubHierarchyType` or left blank. This field must either be left blank or set to `AllSubHierarchyType` when assigning SLA to a snappable or to an object that does not support multiple snappable types.
    - shouldApplyToNonPolicySnapshots - System.Boolean: Boolean value to indicate if the new configuration keeps existing, non-policy snapshots of data sources retained by this SLA Domain.
    - userNote - System.String: Optional User note.
- Returns SlaAssignResult.
### assignretentiontosnapshot
- There are 4 arguments.
    - globalSlaOptionalFid - System.String: Global SLA Domain forever UUID.
    - globalSlaAssignType - SlaAssignTypeEnum: Corresponds to the assignment type for the global SLA
    - snapshotFids - list of System.Strings: List of UUIDs of objects.
    - userNote - System.String: Optional User note.
- Returns SlaAssignResult.
### assignsforsnappablehierarchie
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
### createglobal
Create SLA Domain.

- There is a single argument of type CreateGlobalSlaInput.
- Returns GlobalSlaReply.
### deleteglobal
- There are 2 arguments.
    - id - System.String: SLA Domain ID.
    - userNote - System.String: Optional User note.
- Returns SlaResult.
### editglobal
- There is a single argument of type GlobalSlaEditRequest.
- Returns GlobalSlaReply.
### exportmanagedvolumesnapshot
Create a request to export a snapshot and mount it on a host

Supported in v5.3+
Export a managed volume snapshot as a share and mount it on a given host.

- There is a single argument of type ExportSlaManagedVolumeSnapshotInput.
- Returns AsyncRequestStatus.
### getpendingassignment
Get pending SLA Domain assignments on selected managed objects

Supported in v5.2+
Retrieve the details of pending SLA Domain assignments on the given managed objects. For objects with pending assignments, return the SLA Domain that is pending. For objects without pending assignments, return the current SLA Domain information. Explicitly list invalid object IDs.

- There is a single argument of type GetPendingSlaAssignmentsInput.
- Returns PendingSlaOperations.
### pause
Pause/Resume Global SLA on the given clusters.

- There is a single argument of type PauseSlaRequest.
- Returns SlaResult.
### updateglobal
Update SLA Domain.

- There is a single argument of type UpdateGlobalSlaInput.
- Returns GlobalSlaReply.
### upgrade
Upgrade SLA Domains from the Rubrik clusters.

- There is a single argument of type UpgradeSlasInput.
- Returns UpgradeSlasReply.
