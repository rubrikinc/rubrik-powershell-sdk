# New-RscQueryMongo
## Subcommands
### bulkrecoverablerange
Recoverable range for multiple Management Objects on NoSQL cluster.

- There is a single argument of type MosaicBulkRecoveryRangeInput.
- Returns MosaicRecoveryRangeResponse.
### bulkrecoverableranges
Provides the bulk recoverable range for MongoDB object recovery, including data and log snapshots.

- There is a single argument of type RecoverableRangeInput.
- Returns MongoRecoverableRanges.
### collection
Provides details for a MongoDB collection identified by the fid.

- There is a single argument of type System.String.
- Returns MongoCollection.
### collectionrecoverablerange
Recoverable Range of a MongoDB collection on NoSQL cluster.

- There is a single argument of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### collections
Paginated list of MongoDB collections.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongoCollectionConnection.
### database
Provides details for a MongoDB database identified by the fid.

- There is a single argument of type System.String.
- Returns MongoDatabase.
### databases
Paginated list of MongoDB databases.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongoDatabaseConnection.
### recoverableranges
Provides the point in time range for MongoDB object recovery.

- There is a single argument of type RecoverableRangeInput.
- Returns MongoRecoverableRanges.
### source
Provides details for the MongoDB source cluster identified by the fid.

- There is a single argument of type System.String.
- Returns MongoSource.
### sources
Paginated list of MongoDB sources.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongoSourceConnection.
