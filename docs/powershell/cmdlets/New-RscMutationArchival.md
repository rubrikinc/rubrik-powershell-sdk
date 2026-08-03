# New-RscMutationArchival
## Subcommands
### createglacierreadertarget
Create a reader target of type Glacier on a Rubrik cluster.

- There is a single argument of type CreateGlacierReaderTargetInput.
- Returns Target.
### createmanualtargetmapping
- There is a single argument of type CreateManualTargetMappingInput.
- Returns TargetMapping.
### creates3compatiblereadertarget
Creates reader type for S3Compatible archival location on a CDM cluster.

- There is a single argument of type CreateS3CompatibleReaderTargetInput.
- Returns Target.
### creates3compatibletarget
- There is a single argument of type CreateS3CompatibleTargetInput.
- Returns Target.
### deletetarget
Deletes an archival location.

- There is a single argument of type DeleteTargetInput.
- Returns System.String.
### deletetargetmapping
Deletes mapping of a target.

- There is a single argument of type DeleteTargetMappingInput.
- Returns System.String.
### disabletarget
Disables an Archival Location.

- There is a single argument of type DisableTargetInput.
- Returns DisableTargetReply.
### enabletarget
Enables an Archival Location.

- There is a single argument of type EnableTargetInput.
- Returns EnableTargetReply.
### filesetdownloadsnapshotfilesfromlocation
Initiate a job to download files or folders

Supported in v8.0+
Initiates a job to download one or more files or folders from an archived Fileset snapshot. Returns the job instance ID.

- There is a single argument of type FilesetDownloadSnapshotFilesFromArchivalLocationInput.
- Returns AsyncRequestStatus.
### finishmigration
Finishes an archival migration by swapping the source location's
backing storage to point to the migration target.

Prerequisites:
- Data copy to the migration target must be complete.
- Data validation must have succeeded.

Calling this before prerequisites are met may result in data loss
or an inconsistent location state.

- There is a single argument of type FinishArchivalMigrationInput.
- Returns FinishArchivalMigrationReply.
### pausetarget
Pauses an Archival Location.

- There is a single argument of type PauseTargetInput.
- Returns PauseTargetReply.
### promotereadertarget
Promotes a reader Archival Location.

- There is a single argument of type PromoteReaderTargetInput.
- Returns System.String.
### refreshreadertarget
Refreshes a reader Archival Location.

- There is a single argument of type RefreshReaderTargetInput.
- Returns System.String.
### registermigration
Registers an archival migration from a source archival location to a target
location, by passing the source location id and target location details.

- There is a single argument of type RegisterArchivalMigrationInput.
- Returns RegisterArchivalMigrationReply.
### resumetarget
Resumes an Archival Location.

- There is a single argument of type ResumeTargetInput.
- Returns ResumeTargetReply.
### terminatemigration
Terminates an in-progress archival migration,
marking the migration as cancelled.

- There is a single argument of type TerminateArchivalMigrationInput.
- Returns TerminateArchivalMigrationReply.
### updateglaciertarget
Edit a target of type Glacier on a Rubrik cluster.

- There is a single argument of type UpdateGlacierTargetInput.
- Returns Target.
### updatemanualtargetmapping
- There is a single argument of type UpdateManualTargetMappingInput.
- Returns TargetMapping.
### updatepurestorageprotectiongroupquiescetargets
Replace the persisted quiesce-target selection for a Pure Storage protection group.

Supported in v9.6
Replace the customer-selected list of quiesce targets (VMware virtual machines and RBA-installed hosts) persisted on the protection group. The request body is a full replacement of the prior selection; sending an empty list clears the selection. At snapshot time the pipeline runs pre/post scripts only on the entries in this list. A APP_CONSISTENT mandate with an empty selection downgrades the snapshot to CRASH_CONSISTENT and emits an AppConsistentEmptySelection audit event.

Authorization is through Privilege.ManageBackupScripts, required unconditionally on every call to this endpoint, regardless of whether the request body includes any RBA scripts. The strict check matches the threat model that any PATCH to this endpoint can stage script runs at the next snapshot.

Concurrent edits use last-write-wins; If-Match / ETag is not supported.

Validation failures return 400 with a single uniform error code (PURE_STORAGE_QUIESCE_TARGET_VALIDATION_FAILURE) and a fixed message. Per-entry failure reasons are written to the cluster server log at WARN with the caller principal for audit; they are intentionally not echoed in the response to prevent unprivileged callers from probing for virtual machine or host existence through the error surface.

Audit events: every successful PATCH emits the UpdatePureStorageProtectionGroupQuiesceTargetsAudit event unconditionally. When the cluster trusted-path check is turned off, a second backup-script-checks audit event is emitted in addition.

- There is a single argument of type UpdatePureStorageProtectionGroupQuiesceTargetsInput.
- Returns UpdatePureStorageProtectionGroupQuiesceTargetsReply.
### updates3compatibletarget
- There is a single argument of type UpdateS3CompatibleTargetInput.
- Returns Target.
### upgradecdmmanagedtarget
Upgrade archival locations managed through a Rubrik cluster.

- There is a single argument of type UpgradeCdmManagedTargetInput.
- Returns System.String.
