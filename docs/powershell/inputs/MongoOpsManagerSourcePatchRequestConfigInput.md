### MongoOpsManagerSourcePatchRequestConfigInput
Supported in v9.2+
  v9.2-v9.3: Configuration for patching an OpsManager managed MongoDB source.
  v9.4+: Configuration for patching a MongoDB source managed by Ops Manager.

- ignoreNodes: list of System.Strings
  - Supported in v9.2+
      v9.2: List of MongoDB source nodes that should be ignored for protection.
      v9.3: List of MongoDB source nodes that should be ignored for protection. Each node is of the format hostname:port.
      v9.4+: List of MongoDB source nodes that should be ignored for protection. Each node is of the format hostname:port. The hostname alias must be the same format as that present in the Ops Manager deployment console.
- opsManagerApiToken: System.String
  - Required. Supported in v9.2+
      v9.2: API token of the OpsManager account.
      v9.3+: API token of the OpsManager deployment.
