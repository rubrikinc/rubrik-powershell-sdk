### ActiveDirectoryRestoreConfigInput
Input for Active Directory objects restore.

- domainControllerRestoreConfigs: list of DomainControllerRestoreConfigInputs
  - Required. Restore configuration for each Active Directory Domain Controller.
- shouldPerformAuthoritativeAdObjectsRestore: System.Boolean
  - Required. Whether to perform authoritative Active Directory objects restore or not.
- shouldPerformAuthoritativeSysvolRestore: System.Boolean
  - Required. Whether to perform authoritative SYSVOL restore or not.
- snapshotForAuthoritativeRestore: System.String
  - ID of the snapshot to be used for authoritative restore.
