### CreateAzureClusterInput
Input for creating an Azure cloud cluster.

- cloudAccountId: System.String
  - Customer Azure cloud account ID.
- clusterConfig: ClusterConfigInput
  - Cluster configuration.
- vmConfig: AzureVmConfig
  - Virtual Machine input configuration.
- isEsType: System.Boolean
  - If cluster is CC-ES.
- keepClusterOnFailure: System.Boolean
  - Flag to keep the cluster on failure.
- validations: list of ClusterCreateValidationss
  - Validations to perform on the request.
- isAzResilient: System.Boolean
  - Indicates whether the cluster should be deployed across multiple
availability zones.
