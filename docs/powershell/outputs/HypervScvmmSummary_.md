### HypervScvmmSummary
Supported in v5.0+

- id: System.String
  - Required. Supported in v5.0+
  The ID of the Hyper-V SCVMM.
- primaryClusterId: System.String
  - Required. Supported in v5.0+
- runAsAccount: System.String
  - Required. Supported in v5.0+
  The RunAs account which will be used to install connector on hosts.
- shouldDeployAgent: System.Boolean
  - Required. Supported in v5.0+
  Flag to specify if Rubrik can deploy connector to hosts. If true, Rubrik tries to deploy connector to the hyperv hosts. If false, Rubrik deployment of connector will be handled by the client.
- status: System.String
  - Required. Supported in v5.0+
  Connection status of the SCVMM server.
- scvmmVersion: System.String
  - Supported in v9.0+
  Version of SCVMM.
- statusEnum: HostRbsConnectionStatus
  - 
- slaAssignable: SlaAssignable
  - 
