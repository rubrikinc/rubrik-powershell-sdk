### AksPrivateDnsZoneMode
Private DNS zone mode for the API server of a private AKS cluster.

- AKS_PRIVATE_DNS_ZONE_MODE_UNSPECIFIED - A private DNS zone resolves the API server. Azure creates the zone unless a custom private DNS zone ID is provided.
- AKS_PRIVATE_DNS_ZONE_MODE_NONE - No private DNS zone is used. The API server name resolves through Azure public DNS to the private IP address of the cluster.
