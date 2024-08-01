### UpdateVsphereVmNewInput
Supported in v9.2+. Update a virtual machine with specified properties. Use the guestCredential field to update the guest credential for a specified virtual machine.

- id: System.String
  - ID of vSphere Virtual Machine.
- vmUpdateProperties: VirtualMachineUpdateWithSecretV2Input
  - Properties to update.
- clusterUuid: System.String
  - Uuid of the CDM cluster.
