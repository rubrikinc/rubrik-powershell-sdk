### InPlaceRecoveryJobConfigV2Input
Supported in v5.3+

- shouldKeepVsphereSnapshotAfterRecovery: System.Boolean
  - Supported in v5.3+
      Indicates whether to keeep the vSphere snapshot on the vCenter Server after the in-place recovery or not. Use `true` to keep the snapshot after in-place recovery. Use `false` to delete the snapshot after in-place recovery. The default is `false`.
- shouldPowerOn: System.Boolean
  - Indicates whether to power on the virtual machine after the in-place recovery or not. Use `true` to power on the virtual machine after in-place recovery. Use `false` to not power on the virtual machine after in-place recovery. The default is `true`.
- requiredRecoveryParameters: RequiredRecoveryParametersInput
  - 
