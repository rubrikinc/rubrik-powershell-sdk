### AzureCosmosNosqlNetworkAccessMode
Reachability of an Azure Cosmos NoSQL account, collapsing the account's
public-network-access, IP-rule, VNet-filter and private-endpoint settings
into a single mode. The raw public_network_access value is carried
alongside it so a derivation can be audited against its input.

- AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_UNSPECIFIED - Network access mode has not been determined.
- AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_PUBLIC_OPEN - Reachable from any public network.
- AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_PUBLIC_IP_RESTRICTED - Publicly reachable, restricted to an IP allowlist.
- AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_VNET_RESTRICTED - Reachable only from allowed virtual networks.
- AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_PRIVATE_ENDPOINT_ONLY - Reachable only through private endpoints.
- AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_DISABLED - Not reachable over any network path.
