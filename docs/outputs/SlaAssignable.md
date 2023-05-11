### SlaAssignable
Supported in v5.0+

- configuredSlaDomainId: System.String
  - Required. Supported in v5.0+
  v5.0-v5.1: ID of the configured SLA domain
  v5.2+: The ID of the SLA Domain configured directly on the Rubrik object.
- configuredSlaDomainName: System.String
  - Required. Supported in v5.0+
  v5.0-v5.1: name of the configured SLA domain
  v5.2+: The name of the SLA Domain configured directly on the Rubrik object.
- configuredSlaDomainType: ConfiguredSlaType
  - 
- id: System.String
  - Required. Supported in v5.0+
  v5.0-v5.1: 
  v5.2+: The ID of the Rubrik object.
- isConfiguredSlaDomainRetentionLocked: System.Boolean
  - Supported in v5.1+
  v5.1: A Boolean that indicates whether the configured SLA domain is Retention Locked. When this value is 'true', the configured SLA domain is a Retention Lock SLA Domain.
  v5.2+: Indicates whether the configured SLA Domain is Retention Locked. When this value is 'true', the configured SLA Domain is a Retention Lock SLA Domain.
- name: System.String
  - Required. Supported in v5.0+
  v5.0-v5.1: 
  v5.2+: The name of the Rubrik object.
- primaryClusterId: System.String
  - Required. Supported in v5.0+
  v5.0-v5.1: 
  v5.2+: The ID of the cluster that manages the Rubrik object.
- slaLastUpdateTime: DateTime
  - Supported in v5.2+
  The UTC time when the SLA Domain was last updated.
