# New-RscMutationMongo
## Subcommands
### addopsmanagermanagedsource
Add a new MongoDB source managed by OpsManager

Supported in v9.2+
Adds a new MongoDB source which is managed by OpsManager to the Rubrik Cluster.

- There is a single argument of type AddOpsManagerManagedMongoSourceInput.
- Returns AddOpsManagerMongoSourceResponse.
### addsource
Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.

- There is a single argument of type AddMongoSourceInput.
- Returns AddMongoSourceReply.
### createondemanddatabasebackup
Take an on-demand snapshot for a MongoDB database

Supported in v9.0+
Initiates a job to take an on-demand, full or incremental snapshot of the specified MongoDB database.

- There are 2 arguments.
    - input - CreateOnDemandMongoDatabaseSnapshotInput: Input for V1CreateOnDemandMongoDatabaseSnapshot.
    - attributes - list of FeatureFlagAttributeInputs: List of attributes used to evaluate the feature flag.
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
Edit a MongoDB source

Supported in v9.2+
Edits the properties of a MongoDB source. Name, group ID and cluster ID cannot be modified for a source once added.

- There is a single argument of type PatchOpsManagerManagedMongoSourceInput.
- Returns AsyncRequestStatus.
### patchsource
Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.

- There is a single argument of type PatchMongoSourceInput.
- Returns AsyncRequestStatus.
### recoversource
Recover a MongoDB source from Rubrik CDM cluster.

- There is a single argument of type RecoverMongoSourceInput.
- Returns AsyncRequestStatus.
### retryaddopsmanagermanagedsource
Update a MongoDB source managed by OpsManager

Supported in v9.2+
Updates the configuration of a MongoDB source managed by OpsManager. You can use this endpoint for updating MongoDB source details when the request to add a source fails.

- There is a single argument of type PutOpsManagerManagedMongoSourceInput.
- Returns AsyncRequestStatus.
### retryaddsource
Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.

- There is a single argument of type RetryAddMongoSourceInput.
- Returns AsyncRequestStatus.
