### UpdateNasNamespaceInputInput
Supported in v8.1+
Input to update a NAS namespace.

- id: System.String
  - Required. Supported in v8.1+
ID of the NAS namespace that will be updated.
- userSelectedSmbInterfaces: list of System.Strings
  - Supported in v9.3+
List of hostnames or IP addresses used for Fileset jobs on SMB shares.
- smbCredentials: NasShareCredentialsInput
  - Supported in v8.1+
v8.1-v9.4: Optional credentials that will be used to access all the SMB shares under this NAS namespace unless overridden at the NAS share level. This is applicable for NetApp and Isilon NAS systems only.
v9.5+: Optional credentials that will be used to access all the SMB shares under this NAS namespace unless overridden at the NAS share level. This is applicable for NetApp, Isilon, and FlashBlade NAS systems.
- smbAuthMode: System.String
  - SMB authentication mode override for this specific namespace. When set, takes precedence over the NAS system-level setting and is preserved across discovery cycles.
- userSelectedNfsInterfaces: list of System.Strings
  - Supported in v9.3+
List of hostnames or IP addresses used for Fileset jobs on NFS shares.
- nfsAuthMode: System.String
  - NFS authentication mode for shares under this NAS namespace. UNSPECIFIED clears any namespace-level override and restores inheritance from the NAS system (equivalent to the key being absent). Kerberos modes (KERBEROS_PREFERRED and KERBEROS_ONLY) are accepted only for NetApp NAS namespaces and only while the NFS Kerberos feature (REL_ENABLE_NAS_NFS_KERBEROS) is enabled. STANDARD and UNSPECIFIED are always accepted regardless of discovery state or feature flag status.
