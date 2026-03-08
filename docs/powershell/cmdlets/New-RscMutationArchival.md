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
### updates3compatibletarget
- There is a single argument of type UpdateS3CompatibleTargetInput.
- Returns Target.
### upgradecdmmanagedtarget
Upgrade archival locations managed through a Rubrik cluster.

- There is a single argument of type UpgradeCdmManagedTargetInput.
- Returns System.String.
