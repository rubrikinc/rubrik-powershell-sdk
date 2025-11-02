### HypervInplaceExportJobConfigInput
Supported in v9.1+

- exportVmPath: System.String
  - Supported in v9.1+
v9.1-v9.2: Location to save the Hyper-V Virtual Machine copy on the target host.
v9.3+: DEPRECATED - Location to save the Hyper-V Virtual Machine copy on the target host.
- hostId: System.String
  - Supported in v9.1+
ID of the in-place recovery target host.
- shouldKeepHypervVmCopyAfterRecovery: System.Boolean
  - Supported in v9.1+
v9.1-v9.2: Indicates whether to retain the Hyper-V exported copy on the target server after completing the in-place recovery. Use `true` to keep the snapshot after in-place recovery. Use `false` to delete the snapshot after in-place recovery.
v9.3+: DEPRECATED - Indicates whether to retain the Hyper-V exported copy on the target server after completing the in-place recovery. Use `true` to keep the snapshot after in-place recovery. Use `false` to delete the snapshot after in-place recovery.
