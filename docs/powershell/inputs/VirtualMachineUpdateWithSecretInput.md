### VirtualMachineUpdateWithSecretInput
Supported in v5.0+

- shouldRefreshCacheAfterUpdate: System.Boolean
  - Supported in v5.0+
      A boolean value that specifies whether an update also refreshes the in-memory cache. When 'false' updates do not refresh the in-memory cache. When 'true' updates refresh the in-memory cache. By default, this value is 'true'. Setting this value to 'false' reduces the time required for updates to complete.
- guestCredentialId: System.String
  - Supported in v7.0+
      ID of the guest OS credential to be used for authentication to the virtual machine guest OS. When this ID is specified, the 'guestCredential' field will be ignored.
- shouldUseAgent: System.Boolean
  - Supported in v9.1+
      Boolean field specifying whether to use the Rubrik Backup Service or VMware tools to run pre/post scripts. When 'true', the Rubrik Backup Service is used, otherwise the VMware tools is used.
- guestCredential: BaseGuestCredentialInput
  - Supported in v5.0+
- virtualMachineUpdate: VirtualMachineUpdateInput
  - 
