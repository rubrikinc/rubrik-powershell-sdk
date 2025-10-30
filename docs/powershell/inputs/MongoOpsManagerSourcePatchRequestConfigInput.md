### MongoOpsManagerSourcePatchRequestConfigInput
Supported in v9.2+
  v9.2: Configuration for patching an OpsManager managed MongoDB source.
  v9.3+: Configuration for patching a MongoDB source managed by Ops Manager.

- ignoreNodes: list of System.Strings
  - Supported in v9.2+
      v9.2: List of MongoDB source nodes that should be ignored for protection.
      v9.3+: List of MongoDB source nodes that should be ignored for protection. Each node follows the format hostname:port. The hostname alias must match the format used in the Ops Manager deployment console.
- caCertificateId: System.String
  - Supported in v9.3+
      Certificate ID referencing the certificate imported by using Rubrik's certificate management framework.
- opsManagerApiToken: System.String
  - Required. Supported in v9.2+
      v9.2: API token of the OpsManager account.
      v9.3+: API token of the OpsManager deployment.
