### VirtualMachineUpdateWithSecretV2Input
Supported in v9.2+. Update a virtual machine with specified properties. Use the guestCredential field to update the guest credential for a specified virtual machine.

- shouldRefreshCacheAfterUpdate: System.Boolean
  - A boolean value that specifies whether an updatealso refreshes the in-memory cache. When 'false' updates do notrefresh the in-memory cache. When 'true' updates refresh thein-memory cache. By default, this value is 'true'. Setting thisvalue to 'false' reduces the time required for updates to complete.
- guestCredentialId: System.String
  - ID of the guest OS credential to be used for authenticationto the virtual machine guest OS. When this ID is specified, theguestCredential field will be ignored.
- shouldUseAgent: System.Boolean
  - Boolean field specifying whether to use the Rubrik Backup Service run pre/post scripts. When set to 'true', the Rubrik Backup Service is used. When set to 'false', the VMware tools are used.
- guestCredential: GuestCredentialDefinitionInput
  - Object for guest OS credential definition.
- virtualMachineUpdate: VirtualMachineUpdateInput
  - Object for guest OS credential definition.
