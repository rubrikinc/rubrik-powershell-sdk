### ComputeClusterSummary
Supported in v5.0+

- datacenterId: System.String
  - Required. Supported in v5.0+
- drsStatus: System.Boolean
  - Supported in v5.1+
Current Drs Status of Cluster.
- hostVersions: list of System.Strings
  - Supported in v5.1+
List of Versions of ESXi Hosts in Compute Cluster.
- ioFilterStatus: IoFilterStatus
  - Supported in v5.1+
- lastUsedFqdn: System.String
  - Supported in v5.1+
- effectiveSlaDomainId: System.String
- effectiveSlaDomainName: System.String
- effectiveSlaDomainPolarisManagedId: System.String
  - Optional field containing Polaris managed id of the effective SLA domain if it is Polaris managed.
- effectiveSlaHolder: EffectiveSlaHolder
- effectiveSlaSourceObjectId: System.String
  - ID of the object from which the effective SLA domain is inherited
- effectiveSlaSourceObjectName: System.String
  - Name of the object from which the effective SLA domain is inherited
- slaAssignable: SlaAssignable
