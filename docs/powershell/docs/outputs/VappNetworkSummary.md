### VappNetworkSummary
Supported in v5.0+

- isDeployed: System.Boolean
  - Required. Supported in v5.0+
  Boolean value that indicates whether the specified vApp network object has been deployed. Value is 'true' when the vApp network object has been deployed and 'false' when it has not been deployed.
- name: System.String
  - Required. Supported in v5.0+
  v5.0-v5.3: Name for the specified vApp network object.
  v6.0+: Name of the specified vApp network object.
- parentNetworkId: System.String
  - Supported in v5.0+
  vCloud Director ID of the associated organization VDC network object. For an Isolated network, the value is empty.
