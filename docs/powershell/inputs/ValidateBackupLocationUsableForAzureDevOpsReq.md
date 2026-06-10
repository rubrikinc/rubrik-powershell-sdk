### ValidateBackupLocationUsableForAzureDevOpsReq
Contains parameters to validate backup location for Azure DevOps cloud
account.

- backupLocationId: System.String
  - Archival group ID of the backup location to validate. Retrieve the ID by
calling the allTargetMappings GraphQL query and using the id field of
the desired TargetMapping.
