### MongoOpsManagerSourceAddRequestConfigInput
Supported in v9.2+
  Configuration for adding an OpsManager managed MongoDB source.

- ignoreNodes: list of System.Strings
  - Supported in v9.2+
      v9.2: List of MongoDB source nodes that should be ignored for protection.
      v9.3+: List of MongoDB source nodes that should be ignored for protection. Each node is of the format hostname:port.
- opsManagerApiToken: System.String
  - Required. Supported in v9.2+
      v9.2: API token of the OpsManager account.
      v9.3+: API token of the OpsManager deployment.
- opsManagerClusterId: System.String
  - Required. Supported in v9.2+
      v9.2: Cluster ID of the source as per OpsManager UI.
      v9.3+: Cluster ID of the OpsManager deployment.
- opsManagerGroupId: System.String
  - Required. Supported in v9.2+
      v9.2: Group ID of the source as per OpsManager UI.
      v9.3+: Group ID of the OpsManager deployment.
- opsManagerNodes: list of System.Strings
  - Required. Supported in v9.2+
      v9.2: List of OpsManager nodes along with their ports.
      v9.3+: List of OpsManager nodes along with their ports separated with the colon ':' character. The list must contain at least one OpsManager node in the hostname:port format.
- sourceName: System.String
  - Required. Supported in v9.2+
      Name of the MongoDB cluster.
