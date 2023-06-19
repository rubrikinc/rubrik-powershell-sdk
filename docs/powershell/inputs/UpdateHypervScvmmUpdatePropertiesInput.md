### UpdateHypervScvmmUpdatePropertiesInput
Supported in v5.0+

- configuredSlaDomainId: System.String
  - Supported in v5.0+
      v5.0-v5.1: Assign this SCVMM to the given SLA domain.
      v5.2+: Assign this SCVMM to the given SLA domain. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- hostname: System.String
  - Supported in v5.0+
      Name of the SCVMM host.
- runAsAccount: System.String
  - Supported in v5.0+
      The RunAs account which will be used to install connector on hosts.
- shouldDeployAgent: System.Boolean
  - Supported in v5.0+
      Flag to specify if Rubrik can deploy connector to hosts. If true, Rubrik tries to deploy connector to the hyperv hosts. If false, Rubrik deployment of connector will be handled by the client.
