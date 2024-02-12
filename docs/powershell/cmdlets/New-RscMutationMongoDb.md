# New-RscMutationMongoDb
## Subcommands
### assignslatocollection
Assign SLA Domain to MongoDB collection objects

Supported in v8.1+
Assigns SLA Domain to the given MongoDB collection objects.

- There is a single argument of type AssignSlaToMongoDbCollectionInput.
- Returns AsyncRequestStatus.
### bulkdeletesources
Bulk Delete Sources

Supported in m3.2.0-m4.2.0.

- There is a single argument of type BulkDeleteMosaicSourcesInput.
- Returns MosaicAsyncResponse.
### createsource
Register a new MongoDB source to NoSQL cluster. 
For MongoDB, the term "source" is usually used for either a replica set or a sharded cluster.
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/.

- There is a single argument of type AddMosaicSourceInput.
- Returns MosaicAsyncResponse.
### deletesource
Remove a registered MongoDB source from NoSQL cluster.

- There is a single argument of type DeleteMosaicSourceInput.
- Returns MosaicAsyncResponse.
### recoversource
Recover a MongoDB source from NoSQL cluster.

- There is a single argument of type MosaicRestoreDataInput.
- Returns MosaicAsyncResponse.
### updatesource
Modifies configuration for a registered MongoDB source in NoSQL cluster.

- There is a single argument of type ModifyMosaicSourceInput.
- Returns MosaicAsyncResponse.
