# Invoke-RscMutateMongo
## Subcommands
### Addsource
Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.

- There is a single argument of type AddMongoSourceInput.
- Returns AddMongoSourceReply.
### Assignslatodbcollection
Assign SLA Domain to MongoDB collection objects

Supported in v8.1+
Assigns SLA Domain to the given MongoDB collection objects.

- There is a single argument of type AssignSlaToMongoDbCollectionInput.
- Returns AsyncRequestStatus.
### Bulkdeletedbsource
Bulk Delete Sources

Supported in m3.2.0-m4.2.0.

- There is a single argument of type BulkDeleteMosaicSourcesInput.
- Returns MosaicAsyncResponse.
### Createdbsource
Register a new MongoDB source to NoSQL cluster. 
For MongoDB, the term "source" is usually used for either a replica set or a sharded cluster.
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/.

- There is a single argument of type AddMosaicSourceInput.
- Returns MosaicAsyncResponse.
### Deletedbsource
Remove a registered MongoDB source from NoSQL cluster.

- There is a single argument of type DeleteMosaicSourceInput.
- Returns MosaicAsyncResponse.
### Deletesource
Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.

- There is a single argument of type DeleteMongoSourceInput.
- Returns AsyncRequestStatus.
### Discoversource
Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.

- There is a single argument of type DiscoverMongoSourceInput.
- Returns AsyncRequestStatus.
### Patchsource
Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.

- There is a single argument of type PatchMongoSourceInput.
- Returns AsyncRequestStatus.
### Recoverdbsource
Recover a MongoDB source from NoSQL cluster.

- There is a single argument of type MosaicRestoreDataInput.
- Returns MosaicAsyncResponse.
### Recoversource
Recover a MongoDB source from Rubrik CDM cluster.

- There is a single argument of type RecoverMongoSourceInput.
- Returns AsyncRequestStatus.
### Retryaddsource
Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.

- There is a single argument of type RetryAddMongoSourceInput.
- Returns AsyncRequestStatus.
### Updatedbsource
Modifies configuration for a registered MongoDB source in NoSQL cluster.

- There is a single argument of type ModifyMosaicSourceInput.
- Returns MosaicAsyncResponse.
