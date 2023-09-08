### VcenterSummary
Supported in v5.0+

- configuredSlaDomainPolarisManagedId: System.String
  - Supported in v5.0+
  Optional field containing Polaris managed id of the configured SLA domain if it is Polaris managed.
- hostname: System.String
  - Required. Supported in v5.0+
- username: System.String
  - Required. Supported in v5.0+
- connectionStatus: RefreshableObjectConnectionStatus
  - Supported in v5.1+
  Connection status of a vCenter.
- isIoFilterInstalled: System.Boolean
  - Supported in v5.1+
  A Boolean value that specifies whether Rubrik IO filters are installed on any compute clusters in the vCenter. When this value is 'true,' Rubrik IO filters are present on at least one compute cluster in the vCenter. When this value is 'false,' no Rubrik IO filters are present on any compute clusters in the vCenter.
- lastRefreshTime: DateTime
  - Supported in v5.1+
  Optional field containing the last time that a vcenter was refreshed (either lite or full).
- version: System.String
  - Supported in v5.1+
  Version of vCenter.
- isVmc: System.Boolean
  - Supported in v5.3+
  Indicates if the vCenter is a VMC instance.
- isHotAddProxyEnabledForOnPremVcenter: System.Boolean
  - Supported in v7.0+
  An optional field that specifies whether HotAdd transport mode is enabled for On-Premise vCenter. When this value is `true`, HotAdd transport mode is enabled for this vCenter. When this value is `false`, HotAdd transport mode is disabled for this vCenter. When this value is not specified, it indicates that this is an VMC vCenter.
- vcenterUuid: System.String
  - Supported in v8.0, v9.0+
  v8.0: An optional field that identifies the vCenter Server with a unique identifier.
  v9.0+: An optional field that identifies the vCenter Server with a unique identifier.
- slaAssignable: SlaAssignable
  - 
- vcenterPatch: VcenterPatch
  - 
- conflictResolutionAuthz: VcenterSummaryConflictResolutionAuthz
  - 
- computeVisibilityFilter: list of ClusterVisibilityInfos
  - Supported in v6.0+
  Compute clusters that are visible to this Rubrik Cluster. All other compute resources are hidden. If 'computeVisibilityFilter' is not specified, all resources are visible. If 'hostGroupFilter' is not specified for a compute cluster, all compute resources in the compute cluster are visible. If a 'hostGroupFilter' is specified for a compute cluster, only vms that currently reside on these hosts are visible.
