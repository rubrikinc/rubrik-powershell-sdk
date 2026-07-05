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
- aksCustomPrivateDnsZoneId: System.String
  - Azure resource ID of the private DNS zone which will be used to resolve the API server URL for private exoclusters.
- aksClusterAccessType: AKSClusterAccessType
  - Access type of the AKS cluster, whether it is public or private.
- azureSqlPrivateDnsZoneId: System.String
  - Azure resource ID of the private DNS zone which will be used to resolve the Azure SQL Private Endpoints.
- diskEncryptionSetId: System.String
  - Azure resource ID of the disk encryption set which will be used to encrypt the AKS node disks using customer managed keys.
- azurePostgresFlexServerSubnetNativeId: System.String
  - Azure resource ID of the subnet, in the exocompute VNet, that is
delegated to Microsoft.DBforPostgreSQL/flexibleServers. This subnet is
used for VNet integration of Rubrik-managed Azure Postgres Flexible
Servers. Must be different from the exocompute (AKS) subnet - AKS
cannot launch in a delegated subnet.
Minimum subnet size: /28 (16 IPs). This is Azure's hard requirement for
Postgres Flexible Server delegated subnets - Azure reserves 5 addresses
per delegated subnet for its own use, so a smaller prefix cannot host
any Postgres instance.
- azurePostgresFlexServerPrivateDnsZoneId: System.String
  - Azure resource ID of the private DNS zone used to resolve FQDNs of
Rubrik-managed Azure Postgres Flexible Servers from the exocompute
subnet.
- healthCheckVmNamePrefix: System.String
  - Customer-configured name prefix for the health-check launch virtual machine. When empty,
the default prefix is used. A Rubrik-owned marker and a UUID suffix are
appended automatically and are not part of this value.
