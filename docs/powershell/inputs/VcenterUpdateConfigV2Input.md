### VcenterUpdateConfigV2Input
Supported in v8.1+

- caCerts: System.String
  - Supported in v8.1+
      Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- shouldEnableHotAddProxyForOnPrem: System.Boolean
  - Supported in v8.1+
      v8.1-v9.1: A Boolean value that determines whether to enable HotAdd transport mode for On-Premise vCenter. When this value is `true`, VMware virtual machines can use HotAdd proxy to transport virtual disk data in addition to NBDSSL. When this value is `false`, VMware virtual machines can only use NBDSSL to transport virtual disk data. Default value is `false`.
      v9.2+: A Boolean value that determines whether to enable HotAdd transport mode for On-Premise vCenter. When this value is `true`, VMware virtual machines can use HotAdd proxy to transport virtual disk data in addition to NBD(SSL). When this value is `false`, VMware virtual machines can only use NBD(SSL) to transport virtual disk data. Default value is `false`.
- conflictResolutionAuthz: VcenterUpdateConfigV2ConflictResolutionAuthz
  - Supported in v8.1+
      v8.1-v9.1: Set to 'AllowAutoConflictResolution' to link the relic virtual machine objects of a virtual machine to the current object for the virtual machine or to 'NoConflictResolution' to prevent linking. The Rubrik cluster generates a unique ID for each virtual machine when a vCenter Server is added. When a virtual machine changes to another vCenter Server or unregisters and registers with the same vCenter Server, a new unique ID is generated for that virtual machine. When this happens, the virtual machine object associated with the original ID becomes a relic. Setting this option to 'AllowAutoConflictResolution' links relic virtual machine objects with the current virtual machine object of a specific virtual machine, and makes the collective snapshot history available through the current object. Default value is 'NoConflictResolution'.
      v9.2+: Set to 'AllowAutoConflictResolution' to link the relic virtual machine objects of a virtual machine to the current object for the virtual machine or to 'NoConflictResolution' to prevent linking. The Rubrik cluster generates a unique ID for each virtual machine when a vCenter Server is added. When a virtual machine changes to another vCenter Server or unregisters and registers with the same vCenter Server, a new unique ID is generated for that virtual machine. When this happens, the virtual machine object associated with the original ID becomes a relic. This option links relic virtual machine objects with the current virtual machine object of a specific virtual machine, and makes the collective snapshot history available through the current object. Default value is 'NoConflictResolution'.
- hostname: System.String
  - Required. Supported in v8.1+
- password: System.String
  - Required. Supported in v8.1+
- username: System.String
  - Required. Supported in v8.1+
