### MongoOpsManagerSourceAddRequestConfigInput
Supported in v9.2+
  v9.2: Configuration for adding an OpsManager managed MongoDB source.
  v9.3+: Configuration for adding a MongoDB source managed by Ops Manager.

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
      v9.3+: API token of the Ops Manager deployment.
- opsManagerClusterId: System.String
  - Required. Supported in v9.2+
      v9.2: Cluster ID of the source as per OpsManager UI.
      v9.3+: Cluster / Deployment ID of the MongoDB source managed by Ops Manager.
- opsManagerGroupId: System.String
  - Required. Supported in v9.2+
      v9.2: Group ID of the source as per OpsManager UI.
      v9.3+: Group / Project ID of the MongoDB source managed by Ops Manager.
- opsManagerNodes: list of System.Strings
  - Required. Supported in v9.2+
      v9.2: List of OpsManager nodes along with their ports.
      v9.3+: List of Ops Manager nodes along with their ports, separated by the colon ':' character. The list must contain exactly one Ops Manager node in the hostname:port format. If the Ops Manager is deployed in High Availability (HA) mode, the hostname must be that of the load balancer node.
- sourceName: System.String
  - Required. Supported in v9.2+
      v9.2: Name of the MongoDB cluster.
      v9.3+: Unique name of the MongoDB source which will act as an identifier on Rubrik.
