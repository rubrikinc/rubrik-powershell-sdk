### AirMcpGatewayConnectionData
MCP gateway connection data.

- endpointUrl: System.String
  - Agent-facing gateway URL. Empty until the gateway is deployed.
- idpTenantId: System.String
  - Identity provider tenant the gateway federates to.
- mcpServerIds: list of System.Strings
  - IDs of the MCP servers attached to this gateway.
- idpName: System.String
  - Display name of the identity provider tenant the gateway federates to.
- status: AirGatewayProvisioningState
  - Current provisioning state of the gateway deployment.
- statusError: System.String
  - Secret-free detail of the last deploy error, populated only when the
gateway is in a failed state (FAILED or UPDATE_FAILED). Empty otherwise.
