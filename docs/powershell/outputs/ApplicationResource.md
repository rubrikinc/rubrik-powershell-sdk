### ApplicationResource
Wrapper message that represents either a config resource or a workload
resource within an application.

- discoveryMethod: DiscoveryMethod
  - Method used to discover this application resource.
- effectiveSlaDomain: System.String
  - Effective SLA Domain name of the application this
resource belongs to. Empty when the application is
unprotected or has no SLA assignment.
- protectionStatus: CloudNativeProtectionStatus
  - Protection status of this resource. For a workload resource (EC2/RDS),
this reflects the individual resource's protection status. For a config
resource, this reflects the protection status of its resource type.
- warningFlags: list of ApplicationWarningFlags
  - Actionable protection warnings applying to this resource.
- resource: Resource
  - The underlying config or workload resource.
