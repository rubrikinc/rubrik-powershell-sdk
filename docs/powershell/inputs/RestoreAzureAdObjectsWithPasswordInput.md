### RestoreAzureAdObjectsWithPasswordInput
Configuration to initiate recovery of AzureAdDirectory.

- workloadFid: System.String
  - Workload Fid of the Azure AD Directory to recover.
- snapshotFid: System.String
  - Snapshot FID of the Azure AD directory snapshot from which to recover.
- password: System.String
  - password to recover users of the Azure AD Directory.
- objectTypeToIdMap: list of ObjectInfoTypes
  - Map of AzureAdObjectType to IDs.
