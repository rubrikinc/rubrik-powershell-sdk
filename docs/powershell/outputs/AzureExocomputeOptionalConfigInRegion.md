### AzureExocomputeOptionalConfigInRegion
Represents optional parameters to be configured during the exocompute configuration for Azure.

- aksNodeRgPrefix: System.String
  - Resource group prefix for AKS nodes.
- diskEncryptionAtHost: System.Boolean
  - Disk encryption is enabled for nodes on the AKS cluster.
- additionalWhitelistIps: list of System.Strings
  - Additional IPs that must be whitelisted for the Kubernetes API server of the AKS cluster.
- aksClusterTier: AKSProvisionTier
  - Cluster tier of the provisioned AKS cluster.
- aksNodeCountBucket: AKSNodeCountBucket
  - Bucket to determine the node count in the AKS cluster.
- shouldWhitelistRubrikIps: System.Boolean
  - Determines whether Rubrik IPs are whitelisted for the Kubernetes API server of the AKS cluster.
- enableUserDefinedRouting: System.Boolean
  - Enable user-defined routing as the outbound type for AKS load balancer.
