# New-RscMutationSla
## Subcommands
### assign
Endpoint to assign SLA Domain.

- There is a single argument of type AssignSlaInput.
- Returns SlaAssignResult.
### assignretentiontosnappables
Endpoint to assign retention SLA Domain to workloads.

- There are 6 arguments.
    - globalSlaOptionalFid - System.String: SLA Domain forever UUID.
    - globalSlaAssignType - SlaAssignTypeEnum: Corresponds to the assignment type for the SLA Domain.
    - objectIds - list of System.Strings: A list of object forever UUIDs to assign to the SLA Domain.
    - applicableSnappableType - WorkloadLevelHierarchy: Optional workload type selection for SLA Domain assignment is available for workloads that support multiple workload hierarchies. It allows setting an SLA Domain for specific workload types under the workload rather than applying the SLA Domain for all the workload types.

For example, for an AWS account object with two different workload types, AwsNativeEc2Instance and AwsNativeRdsInstance, the appropriate type can be selected to apply the SLA Domain only to the selected workloads under that account. If the SLA Domain must be applicable to all workload types, the field can be set to AllSubHierarchyType or left blank. However, for workloads that do not support multiple workload types, this field must either be left blank or set to AllSubHierarchyType when assigning the SLA Domain to a workload.
    - shouldApplyToNonPolicySnapshots - System.Boolean: Specifies whether the new configuration keeps existing, non-policy snapshots of data sources retained by this SLA Domain.
    - userNote - System.String: Optional user note.
- Returns SlaAssignResult.
### assignretentiontosnapshots
Endpoint to assign retention SLA Domain to snapshots.

- There are 4 arguments.
    - globalSlaOptionalFid - System.String: SLA Domain forever UUID.
    - globalSlaAssignType - SlaAssignTypeEnum: Corresponds to the assignment type for the SLA Domain.
    - snapshotFids - list of System.Strings: List of snapshot UUIDs.
    - userNote - System.String: Optional user note.
- Returns SlaAssignResult.
### assignsforsnappablehierarchies
Assign SLA Domain to workloads with multiple hierarchies.

- There are 8 arguments.
    - globalSlaOptionalFid - System.String: SLA Domain forever UUID.
    - globalSlaAssignType - SlaAssignTypeEnum: Corresponds to the assignment type for the SLA Domain.
    - objectIds - list of System.Strings: A list of object forever UUIDs to assign to the SLA Domain.
    - applicableSnappableTypes - list of WorkloadLevelHierarchys: Provide optional workload types under the object for SLA Domain assignment. This is meant to be used only for objects that support multiple workload hierarchies. This allows an SLA Domain to be set for one or more specific workload types under the object, instead of applying the SLA Domain for all the workload types. For example, an AWS account object can potentially have 2 different workload types under it - AwsNativeEc2Instance and AwsNativeRdsInstance. This field can be set with the appropriate type so that the SLA Domain only gets applied to workloads of the selected type under that account. If the SLA Domain must be applicable for all the workload types under the object, then this field can be set to `AllSubHierarchyType` or left blank. This field must either be left blank or set to `AllSubHierarchyType` when assigning SLA Domain to a workload or to an object that does not support multiple workload types. If more than one is provided, the SLA will be assigned to all.
    - shouldApplyToExistingSnapshots - System.Boolean: Specifies whether to apply SLA Domain changes to existing snapshots.
    - shouldApplyToNonPolicySnapshots - System.Boolean: Specifies whether the new configuration keeps existing, non-policy snapshots of data sources retained by this SLA Domain.
    - globalExistingSnapshotRetention - GlobalExistingSnapshotRetention: Choose the behavior for existing snapshots when the Do Not Protect option is selected instead of an SLA Domain.
    - userNote - System.String: Optional user note.
- Returns list of SlaAssignResults.
### createglobal
Create SLA Domain.

- There is a single argument of type CreateGlobalSlaInput.
- Returns GlobalSlaReply.
### deleteglobal
- There are 2 arguments.
    - id - System.String: SLA Domain ID.
    - userNote - System.String: Optional user note.
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
### getpendingassignments
Get pending SLA Domain assignments on selected managed objects

Supported in v5.2+
Retrieve the details of pending SLA Domain assignments on the given managed objects. For objects with pending assignments, return the SLA Domain that is pending. For objects without pending assignments, return the current SLA Domain information. Explicitly list invalid object IDs.

- There is a single argument of type GetPendingSlaAssignmentsInput.
- Returns GetPendingSlaAssignmentsReply.
### pause
Pause or resume SLA Domain on the given Rubrik clusters.

- There is a single argument of type PauseSlaInput.
- Returns PauseSlaReply.
### pushstoclusters
Push given SLA IDs to their corresponding list of clusters.

- There is a single argument of type PushSLAsToClustersInput.
- Returns PushSLAsToClustersResult.
### startautomigration
Initiates the SLA Domain auto-migration campaign.

- The startautomigration subcommand takes no arguments.
- Returns StartSlaAutoMigrationReply.
### submituserconcernforautomigration
Allows users to submit concerns or problems encountered during the SLA Domain auto-migration campaign.

- There is a single argument of type SubmitUserConcernForSlaAutoMigrationInput.
- Returns System.String.
### switchalls
Switches all SLA Domains over which the user has the required permission.

- The switchalls subcommand takes no arguments.
- Returns SwitchAllSlasReply.
### updateglobal
Update SLA Domain.

- There is a single argument of type UpdateGlobalSlaInput.
- Returns GlobalSlaReply.
### upgrades
Upgrade SLA Domains from the Rubrik clusters.

- There is a single argument of type UpgradeSlasInput.
- Returns UpgradeSlasReply.
