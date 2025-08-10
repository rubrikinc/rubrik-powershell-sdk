### UpdateNasNamespaceInputInput
Supported in v8.1+
  Input to update a NAS namespace.

- userSelectedSmbInterfaces: list of System.Strings
  - List of hostnames or IP addresses used for Fileset jobs on SMB shares.
- userSelectedNfsInterfaces: list of System.Strings
  - List of hostnames or IP addresses used for Fileset jobs on NFS shares.
- id: System.String
  - Required. Supported in v8.1+
      ID of the NAS namespace that will be updated.
- smbCredentials: NasShareCredentialsInput
  - Supported in v8.1+
      Optional credentials that will be used to access all the SMB shares under this NAS namespace unless overridden at the NAS share level. This is applicable for NetApp and Isilon NAS systems only.
