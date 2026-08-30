### DomainControllerRestoreConfigInput
Config for each of the Active Directory Domain Controller to be restored.

- hostId: System.String
  - Supported in v9.0+
ID of the alternate host on which the restore must be performed.
- snapshotId: System.String
  - Required. ID of the snapshot to be used to restore the Active Directory Domain Controller.
- recoveryMethod: RecoveryMethod
  - Recovery method for the domain controller. Defaults to SystemState when unset.
- dsrmAdminPassword: System.String
  - Directory Services Restore Mode admin password. Required for Application-Only recovery.
