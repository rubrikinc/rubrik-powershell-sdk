### VcenterSummaryV2
Supported in v8.1+

- conflictResolutionAuthz: VcenterSummaryV2ConflictResolutionAuthz
  - Supported in v9.0+ Set to 'AllowAutoConflictResolution' to link the relic virtual machine objects of a virtual machine to the current object for the virtual machine or to 'NoConflictResolution' to prevent linking. When a vCenter Server is added, the Rubrik cluster generates a unique ID for each virtual machine. If a virtual machine moves to another vCenter Server or is unregistered and then registered again with the same vCenter Server, a new unique ID is generated. This results in the original virtual machine object becoming a relic. This option links relic virtual machine objects with the current virtual machine object, allowing the snapshot history to be accessed through the current object. The default value is 'NoConflictResolution'.
- isHotAddProxyEnabledForOnPremVcenter: System.Boolean
  - Supported in v9.0+ An optional field that specifies whether HotAdd transport mode is enabled for On-Premise vCenter. When this value is `true`, HotAdd transport mode is enabled for this vCenter. When this value is `false`, HotAdd transport mode is not enabled for this vCenter. If this value is not specified, it indicates that this is a VMware Cloud (VMC) vCenter.
- caCerts: System.String
  - Supported in v8.1+
Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----. Use an empty string to remove the existing certificates for the vCenter.
- slaAssignable: SlaAssignable
  - Details of the SLA Domain assigned to vSphere vCenter.
- hostname: System.String
  - Required. Supported in v8.1+
- username: System.String
  - Required. Supported in v8.1+
