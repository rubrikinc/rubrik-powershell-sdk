### VcenterConfigV2Input
Supported in v5.3+

- caCerts: System.String
  - Supported in v5.3+
      Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- computeVisibilityFilter: list of ClusterVisibilityConfigInputs
  - Supported in v6.0+
      Select compute clusters that must be visible to this Rubrik Cluster. All other compute resources are hidden. If 'computeVisibilityFilter' is not specified, all resources are visible. If 'hostGroupFilter' is not specified for a compute cluster, all compute resources in the compute cluster are visible. If 'hostGroupFilter' is specified for a compute cluster, only virtual machines that currently reside on these hosts are visible. For the stretched cluster configuration (vMSC), specify the appropriate host groups.
- shouldEnableHotAddProxyForOnPrem: System.Boolean
  - Supported in v7.0+
      A Boolean value that determines whether to enable HotAdd transport mode for On-Premise vCenter. When this value is `true`, VMware virtual machines can use HotAdd proxy to transport virtual disk data in addition to NBD(SSL). When this value is `false`, VMware virtual machines can ONLY usee NBD(SSL) to transport virtual disk data. Default value is `false`.
- conflictResolutionAuthz: VcenterConfigV2ConflictResolutionAuthz
  - Supported in v5.3+
      Set to 'AllowAutoConflictResolution' to link the relic virtual machine objects of a virtual machine to the current object for the virtual machine or to 'NoConflictResolution' to prevent linking. The Rubrik cluster generates a unique ID for each virtual machine when a vCenter Server is added. When a virtual machine changes to another vCenter Server or unregisters and registers with the same vCenter Server, a new unique ID is generated for that virtual machine. When this happens, the virtual machine object associated with the original ID becomes a relic. This option links relic virtual machine objects with the current virtual machine object of a specific virtual machine, and makes the collective snapshot history available through the current object. Default value is 'NoConflictResolution'.
- hostname: System.String
  - Required. Supported in v5.3+
      The hostname of the new vCenter.
- password: System.String
  - Required. Supported in v5.3+
      The password of the new vCenter.
- username: System.String
  - Required. Supported in v5.3+
      The username of the new vCenter.
