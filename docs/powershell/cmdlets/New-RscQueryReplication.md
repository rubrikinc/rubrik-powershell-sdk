# New-RscQueryReplication
## Subcommands
### incomingstats
Get a time series of total incoming bandwidth to the replication clusters.

- There is a single argument of type ReplicationBandwidthIncomingInput.
- Returns InternalReplicationBandwidthIncomingResponse.
### networkthrottlebypass
Retrieves replication throttle bypass status for all the targets of a replication source.

- There is a single argument of type QueryReplicationTargetInfoInput.
- Returns ReplicationTargetThrottleBypassSummaryListResponse.
### networkthrottlebypassbyid
Retrieves replication throttle bypass status for a specified replication target and source.

- There is a single argument of type QueryByIdReplicationTargetInfoInput.
- Returns ReplicationNetworkThrottleBypassReply.
### outgoingstats
Get the time series of total outgoing bandwidth from the replication clusters.

- There is a single argument of type ReplicationBandwidthOutgoingInput.
- Returns InternalReplicationBandwidthOutgoingResponse.
### pairs
List of all replication pair Rubrik clusters.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - ReplicationPairsQuerySortByField: Field to sort by for replication pairs.
    - sortOrder - SortOrder: Sort order.
    - filter - ReplicationPairsQueryFilter: Filter for replication pairs query.
- Returns ReplicationPairConnection.
### validsources
Lists all valid replication source clusters.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - ListValidReplicationSourcesSortByField: Field to sort by for valid replication sources.
    - sortOrder - SortOrder: Sort order.
    - isCrossAccount - System.Boolean: Specification for Rubrik clusters to be retrieved - local or cross-account.
- Returns ValidReplicationSourceConnection.
### validtargets
Lists all valid replication target clusters.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - ListValidReplicationTargetsSortByField: Field to sort by for valid replication targets.
    - sortOrder - SortOrder: Sort order.
    - isCrossAccount - System.Boolean: Deprecated. Use ListValidReplicationTargetFilter instead.
    - validReplicationTargetFilter - ListValidReplicationTargetFilter: Filter to retrieve valid replication targets.
- Returns ValidReplicationTargetConnection.
