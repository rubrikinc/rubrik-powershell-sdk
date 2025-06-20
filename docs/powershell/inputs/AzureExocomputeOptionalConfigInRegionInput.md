### AzureExocomputeOptionalConfigInRegionInput
Represents optional parameters that are to be configured during the configuration of exocompute for azure.

- aksNodeRgPrefix: System.String
  - Resource group prefix for AKS nodes.
- diskEncryptionAtHost: System.Boolean
  - Disk encryption is enabled for nodes on the AKS cluster.
- additionalWhitelistIps: list of System.Strings
  - Additional IPs that must be whitelisted for the Kubernetes API server of the AKS cluster.
- enableUserDefinedRouting: System.Boolean
  - Enable user-defined routing as the outbound type for AKS load balancer.
- shouldWhitelistRubrikIps: System.Boolean
  - Determines whether Rubrik IPs are whitelisted for the Kubernetes API server of the AKS cluster.
- privateDnsZoneId: System.String
  - Azure resource ID of the private DNS zone which will be used to resolve private endpoints if using private access to snapshots.
- aksClusterTier: AKSProvisionTier
  - Cluster tier of the provisioned aks cluster.
- aksNodeCountBucket: AKSNodeCountBucket
  - Bucket to determine the node count in the aks cluster.
