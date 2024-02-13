# New-RscQueryMongoDb
## Subcommands
### bulkrecoverablerange
Recoverable range for multiple Management Objects on NoSQL cluster.

- There is a single argument of type MosaicBulkRecoveryRangeInput.
- Returns MosaicRecoveryRangeResponse.
### collection
MongoDB collection identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections

- There is a single argument of type System.String.
- Returns MongodbCollection.
### collectionrecoverablerange
Recoverable Range of a MongoDB collection on NoSQL cluster.

- There is a single argument of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### collections
Paginated list of MongoDB collections on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbCollectionConnection.
### database
MongoDB database identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
A database stores one or more collections of documents. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections/

- There is a single argument of type System.String.
- Returns MongodbDatabase.
### databases
Paginated list of MongoDB databases on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbDatabaseConnection.
### source
MongoDB source cluster identified by FID on NoSQL cluster. 
For MongoDB, the term "source" is usually used for either a replica set or a sharded cluster. 
For more info on MongoDB cluster refer to : https://docs.mongodb.com/manual/introduction/

- There is a single argument of type System.String.
- Returns MongodbSource.
### sources
Paginated list of MongoDB sources on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbSourceConnection.
