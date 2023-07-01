# Invoke-RscQueryMongo
## Subcommands
### collection
Paginated list of MongoDB collections.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongoCollectionConnection.
### database
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
Paginated list of MongoDB collections on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbCollectionConnection.
### dbcollectionrecoverablerange
Recoverable Range of a MongoDB collection on NoSQL cluster.

- There is a single argument of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### dbdatabase
Paginated list of MongoDB databases on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbDatabaseConnection.
### dbsource
Paginated list of MongoDB sources on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbSourceConnection.
### recoverablerange
Provides the range for recovery of MongoDB objects.

- There is a single argument of type RecoverableRangeInput.
- Returns MongoRecoverableRanges.
### source
Paginated list of MongoDB sources.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongoSourceConnection.
