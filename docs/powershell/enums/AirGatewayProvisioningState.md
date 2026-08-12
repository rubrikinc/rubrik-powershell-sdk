### AirGatewayProvisioningState
Provisioning state of an MCP gateway deployment.

- GATEWAY_PROVISIONING_STATE_UNSPECIFIED - Provisioning state is unspecified.
- GATEWAY_PROVISIONING_STATE_NOT_DEPLOYED - The gateway exists but no deploy has been attempted.
- GATEWAY_PROVISIONING_STATE_PROVISIONING - The first deploy is in flight; the gateway has never served traffic.
- GATEWAY_PROVISIONING_STATE_ACTIVE - A deployment is live and serving traffic.
- GATEWAY_PROVISIONING_STATE_FAILED - The first deploy failed; the gateway never came up.
- GATEWAY_PROVISIONING_STATE_UPDATING - An in-place re-deploy of a previously live gateway is in flight.
- GATEWAY_PROVISIONING_STATE_UPDATE_FAILED - The last update did not apply; the previous deployment is still serving.
- GATEWAY_PROVISIONING_STATE_DELETING - The gateway is being torn down; it no longer serves traffic and will be
removed.
