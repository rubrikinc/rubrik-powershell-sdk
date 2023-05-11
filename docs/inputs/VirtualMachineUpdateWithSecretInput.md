### VirtualMachineUpdateWithSecretInput
Supported in v5.0+

- guestCredential: BaseGuestCredentialInput
  - Supported in v5.0+
- guestCredentialId: System.String
  - Supported in v7.0+
      ID of the guest OS credential to be used for authentication to the virtual machine guest OS. When this ID is specified, the 'guestCredential' field will be ignored.
- shouldRefreshCacheAfterUpdate: System.Boolean
  - Supported in v5.0+
      A boolean value that specifies whether an update also refreshes the in-memory cache. When 'false' updates do not refresh the in-memory cache. When 'true' updates refresh the in-memory cache. By default, this value is 'true'. Setting this value to 'false' reduces the time required for updates to complete.
- virtualMachineUpdate: VirtualMachineUpdateInput
  - 
