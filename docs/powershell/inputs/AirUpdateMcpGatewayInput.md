### AirUpdateMcpGatewayInput
Update MCP gateway request.

- id: System.String
  - ID of the MCP gateway to update.
- name: System.String
  - New display name for the gateway.
- memberServerIds: list of System.Strings
  - IDs of the MCP servers the gateway should front after the update. The
full set is authoritative: servers not listed are detached.
