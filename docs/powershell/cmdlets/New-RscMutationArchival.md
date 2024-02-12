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
### resumetarget
- There is a single argument of type ResumeTargetInput.
- Returns ResumeTargetReply.
### updateglaciertarget
Edit a reader target of type Glacier on a Rubrik cluster.

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
