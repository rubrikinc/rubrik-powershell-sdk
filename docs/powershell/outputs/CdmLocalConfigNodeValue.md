### CdmLocalConfigNodeValue
A single per-node value of a CDM local configuration parameter.

- nodeId: System.String
  - Identifier of the node this value belongs to.
- nodeName: System.String
  - Human-readable name of the node.
- state: CdmConfigParamState
  - State of the value relative to its shipped default.
- currentValue: System.String
  - Currently configured value on this node.
- defaultValue: System.String
  - Shipped default value.
- lastSyncedTime: DateTime
  - Time this node's value was last synced from the cluster.
