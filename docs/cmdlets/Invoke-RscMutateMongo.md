# Invoke-RscMutateMongo
## Subcommands
### addSource
Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.

- The Input parameter takes a single value of type AddMongoSourceInput.
- Returns AddMongoSourceReply.
### assignSlaToDbCollection
Assign SLA Domain to MongoDB collection objects

Supported in v8.1+
Assigns SLA Domain to the given MongoDB collection objects.

- The Input parameter takes a single value of type AssignSlaToMongoDbCollectionInput.
- Returns AsyncRequestStatus.
### bulkDeletedbSource
Bulk Delete Sources

Supported in m3.2.0-m4.2.0.

- The Input parameter takes a single value of type BulkDeleteMosaicSourcesInput.
- Returns MosaicAsyncResponse.
### createdbSource
Register a new MongoDB source to NoSQL cluster. 
For MongoDB, the term "source" is usually used for either a replica set or a sharded cluster.
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/.

- The Input parameter takes a single value of type AddMosaicSourceInput.
- Returns MosaicAsyncResponse.
### deleteSource
Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.

- The Input parameter takes a single value of type DeleteMongoSourceInput.
- Returns AsyncRequestStatus.
### deletedbSource
Remove a registered MongoDB source from NoSQL cluster.

- The Input parameter takes a single value of type DeleteMosaicSourceInput.
- Returns MosaicAsyncResponse.
### discoverSource
Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.

- The Input parameter takes a single value of type DiscoverMongoSourceInput.
- Returns AsyncRequestStatus.
### patchSource
Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.

- The Input parameter takes a single value of type PatchMongoSourceInput.
- Returns AsyncRequestStatus.
### recoverSource
Recover a MongoDB source from Rubrik CDM cluster.

- The Input parameter takes a single value of type RecoverMongoSourceInput.
- Returns AsyncRequestStatus.
### recoverdbSource
Recover a MongoDB source from NoSQL cluster.

- The Input parameter takes a single value of type MosaicRestoreDataInput.
- Returns MosaicAsyncResponse.
### retryAddSource
Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.

- The Input parameter takes a single value of type RetryAddMongoSourceInput.
- Returns AsyncRequestStatus.
### updatedbSource
Modifies configuration for a registered MongoDB source in NoSQL cluster.

- The Input parameter takes a single value of type ModifyMosaicSourceInput.
- Returns MosaicAsyncResponse.
