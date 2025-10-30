### CdmWorkload
Supported in v5.0+

- effectiveSlaDomainId: System.String
  - Supported in v5.0
ID of the effective SLA domain
- effectiveSlaDomainName: System.String
  - Supported in v5.0
name of the effective SLA domain
- effectiveSlaDomainPolarisManagedId: System.String
  - Supported in v5.0
Optional field containing Polaris managed id of the effective SLA domain if it is Polaris managed.
- effectiveSlaSourceObjectId: System.String
  - Supported in v5.0
ID of the object from which the effective SLA domain is inherited
- effectiveSlaSourceObjectName: System.String
  - Supported in v5.0
Name of the object from which the effective SLA domain is inherited
- slaAssignment: SnappableSlaAssignment
  - Required. Supported in v5.0+
v5.0-v5.1: SLA assignment type
v5.2+: The SLA assignment type. Direct SLA assignment means that a SLA Domain was configured directly on the Rubrik object by the user. Derived SLA assignment means that the Rubrik object inherits an SLA Domain from its parent Rubrik object.
- retentionSlaDomainId: System.String
  - Supported in v5.2+
The ID of the SLA Domain whose retention policy is in use.
- effectiveSlaHolder: EffectiveSlaHolder
- slaAssignable: SlaAssignable
