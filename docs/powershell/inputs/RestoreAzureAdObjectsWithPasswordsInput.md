### RestoreAzureAdObjectsWithPasswordsInput
Configuration to initiate recovery of AzureAdDirectory with multiple passwords.

- workloadFid: System.String
  - Workload Fid of the Azure AD Directory to recover.
- snapshotFid: System.String
  - Snapshot FID of the Azure AD directory snapshot from which to recover.
- passwordByUserIdMap: list of PasswordByUserIds
  - Map of user IDs to password.
- objectTypeToIdMap: list of ObjectInfoTypes
  - Map of azureAdObjectType to object IDs.
- forceChangePasswordWithMfa: System.Boolean
  - Specifies whether to enable MFA during the recovery of one or more users.
