### RestoreFilesJobConfigInput
Supported in v5.0+

- domainName: System.String
  - Supported in v5.0+
      Domain name (Use . for local admin).
- ignoreErrors: System.Boolean
  - Supported in v5.0+
      v5.0: Optional field to determine whether to ignore errors during restore jobs that use the Rubrik Backup Service. Default value is false, errors are not ignored.
      v5.1-v7.0: Optional Boolean field to determine whether to ignore errors during restore jobs that use the Rubrik Backup Service. When 'true', errors are ignored. Default value is 'false', errors are not ignored.
      v8.0+: Optional Boolean field specifying whether to ignore errors during restore jobs that use the Rubrik Backup Service. When 'true', errors are ignored. When 'false', errors are not ignored. The default value is 'false'.
- password: System.String
  - Supported in v5.0+
      Password.
- shouldSaveCredentials: System.Boolean
  - Supported in v5.0+
      v5.0: Whether we should save the user-entered credentials
      v5.1-v7.0: A Boolean value that specifies whether to save the user-entered credentials. When 'true', the user-entered credentials are saved.
      v8.0+: Boolean value specifying whether to save the user-entered credentials. When 'true', the user-entered credentials are saved.
- username: System.String
  - Supported in v5.0+
      Username.
- destObjectId: System.String
  - Supported in v5.1+
      Managed ID of the destination object that the files should be recovered to.
- shouldRestoreXAttrs: System.Boolean
  - Supported in v5.1+
      v5.1-v7.0: Boolean value that determines restore file settings for Linux systems and for Windows systems. For Linux, use 'true' to include the extended attributes of restored files. For Windows, use 'true' to include alternate data streams for restored files. For both, use 'false' to exclude this additional metadata.
      v8.0+: Boolean value specifying the restore file settings for Linux and Windows systems. For Linux, use 'true' to include the extended attributes of restored files. For Windows, use 'true' to include alternate data streams for restored files. For both systems, use 'false' to exclude this additional metadata.
- shouldUseAgent: System.Boolean
  - Supported in v5.1+
      v5.1-v7.0: A Boolean that specifies whether to use the Rubrik Backup Service or VMware tools to restore files. When 'true', the RBS restores files. When 'false',the VMware tools restores files.
      v8.0+: Boolean field specifying whether to use the Rubrik Backup Service or VMware tools to restore files. When 'true', the RBS restores files. When 'false',the VMware tools restores files.
- guestCredentialId: System.String
  - Supported in v7.0+
      v7.0: ID of the guest OS credential that should be used for authentication when restoring files through the VMware tools. When this ID is specified, the 'domainName', 'username', 'password', and 'shouldSaveCredentials' fields will be ignored.
      v8.0+: ID of the guest OS credential used for authentication when restoring files through the VMware tools. When this ID is specified, the 'domainName', 'username', 'password', and 'shouldSaveCredentials' fields are ignored.
- description: System.String
  - Supported in v9.2+
      Description.
- shouldUseMountDisks: System.Boolean
  - Supported in v9.1+
      Boolean field specifying whether to mount disks during restore jobs. When the value is 'true', the VMDK disks of the snapshot are mounted on the target VM for recovering the files and the parameter 'shouldUseAgent' is ignored. When the value is 'false', RSC may or may not use agent.
- restoreConfig: list of VmRestorePathPairInputs
  - Required. Supported in v5.0+
      v5.0-v5.3: Absolute file path and restore path if not restored back to itself
      v6.0-v7.0: Absolute file path and restore path if not restored back to itself.
      v8.0+: Absolute file path and restore path if the object is not restored back to itself.
