### CreateVappNetworkParams
Supported in v5.0+

- newName: System.String
  - Supported in v5.0+
  v5.0-v5.3: Name to assign within vCloud to the vApp network that is referenced by the specified new vApp network object. The Rubrik REST API server uses this value, when present, to rename the vApp network within vCloud. When this value is empty the vApp network uses the existing name.
  v6.0+: Name to assign to the vApp network that is referenced by the specified new vApp network object. If a name is specified, the Rubrik REST API server uses the name to rename the vApp network within the vCloud. If the value is empty, the vApp network is not renamed.
- vappNetworkSummary: VappNetworkSummary
  - Network summary of the vApp to be created.
