### MongoOpsManagerSourcePatchRequestConfigInput
Supported in v9.2+
  Configuration for patching an OpsManager managed MongoDB source.

- ignoreNodes: list of System.Strings
  - Supported in v9.2+
      v9.2: List of MongoDB source nodes that should be ignored for protection.
      v9.3+: List of MongoDB source nodes that should be ignored for protection. Each node is of the format hostname:port.
- opsManagerApiToken: System.String
  - Required. Supported in v9.2+
      v9.2: API token of the OpsManager account.
      v9.3+: API token of the OpsManager deployment.
