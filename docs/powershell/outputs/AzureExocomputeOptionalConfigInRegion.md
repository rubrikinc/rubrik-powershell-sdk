### AzureExocomputeOptionalConfigInRegion
Represents optional parameters to be configured during the exocompute configuration for Azure.

- aksClusterTier: AKSProvisionTier
  - Cluster tier of the provisioned AKS cluster.
- aksNodeCountBucket: AKSNodeCountBucket
  - Bucket to determine the node count in the AKS cluster.
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
NOTE:
This is the private DNS zone ID used to resolve private endpoints linked
to snapshots. The name of this DNS zone must be exactly
`privatelink.blob.core.windows.net`.
- aksCustomPrivateDnsZoneId: System.String
  - Azure resource ID of the private DNS zone which will be used to resolve
the API server URL for private exoclusters. If empty, Azure will
automatically create a private DNS zone each time an AKS cluster is
launched (in the node resource group).
NOTE:
This is different from the private DNS zone used to resolve private
endpoints linked to snapshots. The name of this DNS zone must be either:
`privatelink.<region>.azmk8s.io` OR
`<subzone>.privatelink.<region>.azmk8s.io`.
- aksClusterAccessType: AKSClusterAccessType
  - Determines whether the AKS cluster should be public or private. We assume
public if this field is left unspecified.
If private mode is selected, it will only be respected if the feature flag
for private exoclusters is enabled and we have sufficient permissions
to launch private clusters.
