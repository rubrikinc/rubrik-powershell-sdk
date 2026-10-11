### O365SaasSetupCompleteInput
Configuration for the setup of a Rubrik-hosted subscription.

- tenantId: System.String
  - ID of the Azure tenant.
- regionName: System.String
  - The value of this field depends on the value of the storeBackupInSameRegionAsData field. When its value is false, regionName represents the Azure region name. When true, regionName represents the name of the central data location of the M365 organization.
- stateToken: System.String
  - CSRF token for the setup flow.
- appTypes: list of System.Strings
  - Types of the apps created in the flow.
- kmsSpec: KmsSpecInput
  - Azure KMS configuration, excluding the app secret. Mutually exclusive with
uem_kms_spec; enforced in the service handler.
- storeBackupInSameRegionAsData: System.Boolean
  - Specifies whether the backups will be stored in the same region as the source data. When true, the regionName field represents the name of the central data location of the M365 organization.
- prioritizedOnboardingSpec: PrioritizedOnboardingSpec
  - Prioritized onboarding configuration.
- uemKmsSpec: UemKmsSpecInput
  - UEM-managed KMS configuration. Set when the customer opts for a
UEM-managed KMS. Mutually exclusive with kms_spec.
