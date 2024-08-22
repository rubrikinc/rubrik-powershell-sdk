### CreateAzureClusterInput
CreateAzureClusterInput for Azure account.

- cloudAccountId: System.String
  - Customer Azure cloud account ID.
- isEsType: System.Boolean
  - If cluster is CC-ES.
- keepClusterOnFailure: System.Boolean
  - Flag to keep the cluster on failure.
- clusterConfig: ClusterConfigInput
  - Input cluster configuration.
- vmConfig: AzureVmConfig
  - Virtual Machine input configuration.
- validations: list of ClusterCreateValidationss
  - Validations to perform on the request.
