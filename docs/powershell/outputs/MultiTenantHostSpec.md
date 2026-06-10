### MultiTenantHostSpec
MultiTenant host specification contains the specs, app ID and network config required
for operations on a multi-tenant host.

- multiTenantHostAzureAppId: System.String
  - Azure App ID of Microsoft Entra ID app used to manage the multi-tenant host.
- multiTenantHostNetworkConfig: NetworkConfig
  - Network configuration of the multi-tenant host.
- multiTenantHostId: System.String
  - Identifier for the multi-tenant host.
- registryServer: System.String
  - Azure container registry server for multi-tenant host.
- tunnelMode: System.String
  - Tunnel mode for the multi-tenant host.
- namespace: System.String
  - Namespace assigned to the exocluster on the multi-tenant host, where the pods will be deployed.
