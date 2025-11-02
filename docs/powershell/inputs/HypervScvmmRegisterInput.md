### HypervScvmmRegisterInput
Supported in v5.0+

- hostname: System.String
  - Required. Supported in v5.0+
Name of the SCVMM host.
- runAsAccount: System.String
  - Required. Supported in v5.0+
The RunAs account which will be used to install connector on hosts.
- shouldDeployAgent: System.Boolean
  - Required. Supported in v5.0+
Flag to specify if Rubrik can deploy connector to hosts. If true, Rubrik tries to deploy connector to the hyperv hosts. If false, Rubrik deployment of connector will be handled by the client.
