### AzureNativeVmRecoverySpecInput
Resource mapping for Azure native virtual machine recovery.

- snapshotType: SnapshotType
  - The type of the source snapshot to be used for recovery.
- sizeType: System.String
  - The size of the virtual machine to recover to.
- availabilityZone: System.String
  - The zone in which to recover the virtual machine, empty for
regions/virtual machine types which do not support availability zones.
- shouldEnableAcceleratedNetworking: System.Boolean
  - Whether to enable accelerated networking for the recovered
virtual machine.
- resourceGroup: System.String
  - Name of the resource group for the recovered virtual machine.
Note that this is the ID of the Azure native resource group table.
- subnetNativeId: System.String
  - The native ID of the subnet used for the recovered virtual machine.
- networkSecurityGroupNativeId: System.String
  - The native ID of the network security group used for the recovered
virtual machine.
- availabilitySetNativeId: System.String
  - Specifies the availability set to which the virtual machine should be
exported.
- diskEncryptionSetNativeId: System.String
  - Specifies the disk encryption set used to encrypt the newly created
disks attached to the recovered virtual machine.
