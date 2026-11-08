### AzureNativeVirtualMachineRecoverySpec
Azure native virtual machine recovery specification.

- appId: System.String
- snappableId: System.String
- version: System.Int64
- userData: System.String
- recoveryPointOpt: System.Int64
- sizeType: System.String
  - Size type of the recovered VM.
- availabilityZone: System.String
  - Availability zone used for the recovered VM.
- resourceGroup: System.String
  - Resource Group name of the Azure Virtual Machine.
- subnetNativeId: System.String
  - Native ID of the subnet used for the recovered VM.
- networkSecurityGroupNativeId: System.String
  - Native ID of the network security group used for the recovered VM.
- diskEncryptionSetNativeId: System.String
  - Native ID of the disk encryption set used to encrypt the newly created disks.
- availabilitySetNativeId: System.String
  - Native ID of the availability set used for the recovered VM.
- shouldEnableAcceleratedNetworking: System.Boolean
  - Indicates whether accelerated networking should be enabled for the VM's network interface.
- snapshotType: AzureSnapshotType
  - Which type of snapshot used to recovery VM from. This is only used in INSTANCE Spec for a recovery
