### AppAccessGraph
Response for GetAppAccessGraph RPC.

- counts: AppAccessCounts
  - Aggregated app access counts for the principal.
- userAppAccessData: UserAppAccessData
  - Underlying graph data for the principal's app access paths.
- nodes: list of AppAccessNodes
  - Slot-keyed node list for the app access graph layout.
Each AppAccessNodeId slot appears at most once; slots with no data are omitted.
- edges: list of AppAccessEdges
  - Directed edges connecting slots in the app access graph.
