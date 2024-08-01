### MongoOpsManagerSourceAddRequestConfigInput
Supported in v9.2+
  Configuration for adding an OpsManager managed MongoDB source.

- ignoreNodes: list of System.Strings
  - Supported in v9.2+
      List of MongoDB source nodes that should be ignored for protection.
- opsManagerApiToken: System.String
  - Required. Supported in v9.2+
      API token of the OpsManager account.
- opsManagerClusterId: System.String
  - Required. Supported in v9.2+
      Cluster ID of the source as per OpsManager UI.
- opsManagerGroupId: System.String
  - Required. Supported in v9.2+
      Group ID of the source as per OpsManager UI.
- opsManagerNodes: list of System.Strings
  - Required. Supported in v9.2+
      List of OpsManager nodes along with their ports.
- sourceName: System.String
  - Required. Supported in v9.2+
      Name of the MongoDB cluster.
