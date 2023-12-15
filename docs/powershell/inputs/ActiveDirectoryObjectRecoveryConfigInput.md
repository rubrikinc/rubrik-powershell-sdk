### ActiveDirectoryObjectRecoveryConfigInput
Supported in v9.0+

- shouldMergeLinkedAttrs: System.Boolean
  - Supported in v9.0+
      Specifies whether to merge current linked attributes with the ones in backup or to wipe all current and restore to the exact state in backup.
- userRestoreOptions: ActiveDirectoryUserRestoreOptionsInput
  - Supported in v9.0+
      Options for restoring user accounts.
- restoreToDifferentContainer: System.String
  - Supported in v9.0+
      Restore the objects to a different container.
- shouldContinueOnError: System.Boolean
  - Supported in v9.0+
      Proceed with the recovery process even if you encounter errors.
- clearUpAttrsIfNullInBackup: System.Boolean
  - Supported in v9.0+
      Specifies whether to remove the attribute if it is not present in the backup copy but is present in the Active Directory live copy.
- credsForRestore: ActiveDirectoryRecoveryLdapCredsInput
  - Supported in v9.0+
      Credentials required for LDAP binding.
- shouldCreateMissingParents: System.Boolean
  - Supported in v9.0+
      Whether to restore the parent objects of the provided Distinguished Name Tag if the parent objects are absent.
- containerRestoreOptions: ActiveDirectoryContainerRestoreOptionsInput
  - Supported in v9.0+
      Options for restoring Containers and Organizational Units (OUs).
- locationId: System.String
  - Supported in v9.0+
      ID of the archival or replication location.
- nameConflict: ActiveDirectoryObjectNameConflictOption
  - Supported in v9.0+
      Behavior to be followed when an object name conflicts with an existing object in Active Directory.
- objectMovedOptions: ActiveDirectoryObjectMovedOption
  - Supported in v9.0+
      Behavior to be followed when an object has been moved across Organizational Units (OUs) or Containers.
- domainControllerRecoveryObjects: list of ActiveDirectoryRecoveryObjectInputs
  - Required. Supported in v9.0+
      Distinguished Name Tag of the objects to be restored.
