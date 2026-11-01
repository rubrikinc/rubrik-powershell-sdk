### DynamoDbRestoreSearchInput
DynamoDbRestoreSearchInput selects the subset of items to recover for a
granular recovery: the partition keys plus optional attribute predicates.

- partitionKeyValues: list of System.Strings
  - Partition key values whose items are recovered.
- filters: list of CloudNativeSearchFilters
  - Optional filters on the sort key or a local secondary index key that
further narrow which items are recovered. The partition key goes in
partitionKeyValues.
