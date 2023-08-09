# Invoke-RscQueryMongo
## Subcommands
### bulkrecoverableranges
Provides the bulk recoverable range for MongoDB object recovery, including data and log snapshots.

- There is a single argument of type RecoverableRangeInput.
- Returns MongoRecoverableRanges.
### collection
Provides details for a MongoDB collection identified by the fid.

- There is a single argument of type System.String.
- Returns MongoCollection.
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
### dbbulkrecoverablerange
Recoverable range for multiple Management Objects on NoSQL cluster.

- There is a single argument of type MosaicBulkRecoveryRangeInput.
- Returns MosaicRecoveryRangeResponse.
### dbcollection
MongoDB collection identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections

- There is a single argument of type System.String.
- Returns MongodbCollection.
### dbcollectionrecoverablerange
Recoverable Range of a MongoDB collection on NoSQL cluster.

- There is a single argument of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### dbcollections
Paginated list of MongoDB collections on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbCollectionConnection.
### dbdatabase
MongoDB database identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
A database stores one or more collections of documents. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections/

- There is a single argument of type System.String.
- Returns MongodbDatabase.
### dbdatabases
Paginated list of MongoDB databases on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbDatabaseConnection.
### dbsource
MongoDB source cluster identified by FID on NoSQL cluster. 
For MongoDB, the term "source" is usually used for either a replica set or a sharded cluster. 
For more info on MongoDB cluster refer to : https://docs.mongodb.com/manual/introduction/

- There is a single argument of type System.String.
- Returns MongodbSource.
### dbsources
Paginated list of MongoDB sources on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbSourceConnection.
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
