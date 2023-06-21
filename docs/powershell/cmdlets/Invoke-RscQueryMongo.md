# Invoke-RscQueryMongo
## Subcommands
### Collection
Paginated list of MongoDB collections.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongoCollectionConnection.
### Database
Paginated list of MongoDB databases.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongoDatabaseConnection.
### Dbbulkrecoverablerange
Recoverable range for multiple Management Objects on NoSQL cluster.

- There is a single argument of type MosaicBulkRecoveryRangeInput.
- Returns MosaicRecoveryRangeResponse.
### Dbcollection
Paginated list of MongoDB collections on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbCollectionConnection.
### Dbcollectionrecoverablerange
Recoverable Range of a MongoDB collection on NoSQL cluster.

- There is a single argument of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### Dbdatabase
Paginated list of MongoDB databases on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbDatabaseConnection.
### Dbsource
Paginated list of MongoDB sources on NoSQL cluster.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongodbSourceConnection.
### Recoverablerange
Provides the range for recovery of MongoDB objects.

- There is a single argument of type RecoverableRangeInput.
- Returns MongoRecoverableRanges.
### Source
Paginated list of MongoDB sources.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MongoSourceConnection.
