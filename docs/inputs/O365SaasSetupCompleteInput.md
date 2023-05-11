### O365SaasSetupCompleteInput
Configuration for the setup of a Rubrik-hosted subscription.

- appTypes: a list of System.Strings
  - Types of the apps created in the flow.
- kmsSpec: KmsSpecInput
  - Azure KMS configuration, excluding the app secret.
- regionName: System.String
  - The value of this field depends on the value of the storeBackupInSameRegionAsData field. When its value is false, regionName represents the Azure region name. When true, regionName represents the name of the central data location of the M365 organization.
- stateToken: System.String
  - CSRF token for the setup flow.
- storeBackupInSameRegionAsData: System.Boolean
  - Specifies whether the backups will be stored in the same region as the source data. When true, the regionName field represents the name of the central data location of the M365 organization.
- tenantId: System.String
  - ID of the Azure tenant.
