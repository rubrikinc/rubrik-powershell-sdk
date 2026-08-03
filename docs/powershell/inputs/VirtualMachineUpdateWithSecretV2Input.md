### VirtualMachineUpdateWithSecretV2Input
Supported in v9.2+. Update a virtual machine with specified properties. Use the guestCredential field to update the guest credential for a specified virtual machine.

- guestCredential: GuestCredentialDefinitionInput
  - Guest credential for the virtual machine.
- shouldRefreshCacheAfterUpdate: System.Boolean
  - A boolean value that specifies whether an update also refreshes the in-memory cache. When 'false' updates do not refresh the in-memory cache. When 'true' updates refresh the in-memory cache. By default, this value is 'true'. Setting this value to 'false' reduces the time required for updates to complete.
- guestCredentialId: System.String
  - ID of the guest OS credential to be used for authentication to the virtual machine guest OS. When this ID is specified, the guestCredential field will be ignored.
- virtualMachineUpdate: VirtualMachineUpdateInput
  - Virtual machine update properties.
- shouldUseAgent: System.Boolean
  - Boolean field specifying whether to use the Rubrik Backup Service run pre/post scripts. When set to 'true', the Rubrik Backup Service is used. When set to 'false', the VMware tools are used.
