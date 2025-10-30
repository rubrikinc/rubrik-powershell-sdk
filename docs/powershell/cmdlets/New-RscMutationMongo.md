# New-RscMutationMongo
## Subcommands
### addopsmanagermanagedsource
Add a new MongoDB source managed by Ops Manager

Supported in v9.2+
Adds a new MongoDB source which is managed by Ops Manager to the Rubrik Cluster.

- There is a single argument of type AddOpsManagerManagedMongoSourceInput.
- Returns AddOpsManagerMongoSourceResponse.
### addsource
v8.1-v9.2: Add a new MongoDB source
v9.3+: Add a new MongoDB source for logical backup and recovery

Supported in v8.1+
v8.1-v9.2: Adds a new MongoDB source to the Rubrik Cluster.
v9.3+: Adds a new MongoDB source to the Rubrik Cluster which would be managed using logical backup and recovery.

- There is a single argument of type AddMongoSourceInput.
- Returns AddMongoSourceReply.
### createondemanddatabasebackup
v9.0-v9.2: Take an on-demand snapshot for a MongoDB database
v9.3+: Take an on-demand logical snapshot for a MongoDB database

Supported in v9.0+
v9.0-v9.2: Initiates a job to take an on-demand, full or incremental snapshot of the specified MongoDB database.
v9.3+: Initiates a job to take an on-demand, full or incremental logical snapshot of the specified MongoDB database.

- There are 2 arguments.
    - input - CreateOnDemandMongoDatabaseSnapshotInput: Input for V1CreateOnDemandMongoDatabaseSnapshot.
    - attributes - list of FeatureFlagAttributeInputs: List of attributes used to evaluate the feature flag.
- Returns AsyncRequestStatus.
### createopsmanagermanagedsourceondemandsnapshot
Take an on-demand snapshot of a MongoDB source managed by Ops Manager

Supported in v9.3+
Initiates a job to take an on-demand, full or incremental snapshot of the specified MongoDB source.

- There is a single argument of type CreateOpsManagerManagedSourceOnDemandSnapshotInput.
- Returns AsyncRequestStatus.
### deletesource
Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.

- There is a single argument of type DeleteMongoSourceInput.
- Returns AsyncRequestStatus.
### discoversource
Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.

- There is a single argument of type DiscoverMongoSourceInput.
- Returns AsyncRequestStatus.
### patchopsmanagermanagedsource
v9.2: Edit a MongoDB source
v9.3+: Edit a MongoDB source managed by Ops Manager

Supported in v9.2+
v9.2: Edits the properties of a MongoDB source. Name, group ID and cluster ID cannot be modified for a source once added.
v9.3+: Edits the properties of a MongoDB source managed by Ops Manager. Source name, Group / Project ID, Cluster / Deployment ID, and the Ops Manager host cannot be modified for a source once added.

- There is a single argument of type PatchOpsManagerManagedMongoSourceInput.
- Returns AsyncRequestStatus.
### patchsource
v8.1-v9.2: Edit a MongoDB source
v9.3+: Edit a MongoDB source managed using logical backup and recovery

Supported in v8.1+
v8.1-v9.2: Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.
v9.3+: Edits the properties of a MongoDB source managed using logical backup and recovery. Hosts, name, and the type of the MongoDB deployment cannot be changed once added.

- There is a single argument of type PatchMongoSourceInput.
- Returns AsyncRequestStatus.
### recoveropsmanagermanagedsource
Recover an existing snapshot to the target MongoDB cluster managed by Ops Manager

Supported in v9.3+
Recovers the selected snapshot to target MongoDB cluster.

- There is a single argument of type RecoverOpsManagerManagedMongoSourceInput.
- Returns AsyncRequestStatus.
### recoversource
Recover a MongoDB source from Rubrik CDM cluster.

- There is a single argument of type RecoverMongoSourceInput.
- Returns AsyncRequestStatus.
### retryaddopsmanagermanagedsource
Update a MongoDB source managed by Ops Manager

Supported in v9.2+
v9.2: Updates the configuration of a MongoDB source managed by OpsManager. You can use this endpoint for updating MongoDB source details when the request to add a source fails.
v9.3+: Updates the configuration of a MongoDB source managed by Ops Manager. This endpoint must be used for updating the MongoDB source details when the request to add a source had previously failed.

- There is a single argument of type PutOpsManagerManagedMongoSourceInput.
- Returns AsyncRequestStatus.
### retryaddsource
v8.1-v9.2: Update a MongoDB source
v9.3+: Update a MongoDB source managed using logical backup and recovery

Supported in v8.1+
v8.1-v9.2: Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.
v9.3+: Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details managed using logical backup and recovery when the request to add a source fails.

- There is a single argument of type RetryAddMongoSourceInput.
- Returns AsyncRequestStatus.
