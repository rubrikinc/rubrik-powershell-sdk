### MongoOpsManagerSourceAddRequestConfigInput
Supported in v9.2+
  v9.2-v9.4: Configuration for adding an OpsManager managed MongoDB source.
  v9.5: Configuration for adding a MongoDB source managed by Ops Manager.

- ignoreNodes: list of System.Strings
  - Supported in v9.2+
      v9.2: List of MongoDB source nodes that should be ignored for protection.
      v9.3-v9.4: List of MongoDB source nodes that should be ignored for protection. Each node is of the format hostname:port.
      v9.5: List of MongoDB source nodes that should be ignored for protection. Each node is of the format hostname:port. The hostname alias must be the same format as that present in the Ops Manager deployment console.
- opsManagerApiToken: System.String
  - Required. Supported in v9.2+
      v9.2: API token of the OpsManager account.
      v9.3-v9.4: API token of the OpsManager deployment.
      v9.5: API token of the Ops Manager deployment.
- opsManagerClusterId: System.String
  - Required. Supported in v9.2+
      v9.2: Cluster ID of the source as per OpsManager UI.
      v9.3-v9.4: Cluster ID of the OpsManager deployment.
      v9.5: Cluster / Deployment ID of the MongoDB source managed by Ops Manager.
- opsManagerGroupId: System.String
  - Required. Supported in v9.2+
      v9.2: Group ID of the source as per OpsManager UI.
      v9.3-v9.4: Group ID of the OpsManager deployment.
      v9.5: Group / Project ID of the MongoDB source managed by Ops Manager.
- opsManagerNodes: list of System.Strings
  - Required. Supported in v9.2+
      v9.2: List of OpsManager nodes along with their ports.
      v9.3-v9.4: List of OpsManager nodes along with their ports separated with the colon ':' character. The list must contain at least one OpsManager node in the hostname:port format.
      v9.5: List of Ops Manager nodes along with their ports separated with the colon ':' character. The list must contain exactly one Ops Manager node in the hostname:port format. The hostname must be of the load balancer node if the Ops Manager is deployed in High Availability (HA) mode.
- sourceName: System.String
  - Required. Supported in v9.2+
      v9.2-v9.4: Name of the MongoDB cluster.
      v9.5: Unique name of the MongoDB source which will act as an identifier on Rubrik.
