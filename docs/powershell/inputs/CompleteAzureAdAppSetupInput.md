### CompleteAzureAdAppSetupInput
Configuration to complete the Azure AD application creation flow.

- domainName: System.String
  - Domain name of the MSFT tenant for which the application was created.
- stateToken: System.String
  - CSRF token from the setup flow. Required unless event_hub_only is true, in
which case there is no directory setup to complete and the token is unused.
- kmsSpec: KmsSpecInput
  - Azure KMS configuration.
- uemKmsSpec: UemKmsSpecInput
  - UEM Azure KMS configuration.
- eventHubOnboarding: EntraIdEventHubOnboarding
  - Optional Event Hub ingestion settings for the OAuth path. When set, Rubrik
also enables Event Hub ingestion for the tenant as part of completing the
Entra ID app setup. Mutually exclusive with event_hub_onboarding_without_oauth.
- eventHubOnboardingWithoutOauth: EntraIdEventHubOnboardingWithoutOAuth
  - Optional Event Hub ingestion settings for the non-OAuth (customer BYO app +
BYO hub) path. When set, Rubrik enables Event Hub ingestion against the
customer's existing hub. Mutually exclusive with event_hub_onboarding.
- eventHubOnly: System.Boolean
  - When true, add Event Hub ingestion to an already-onboarded Entra ID
directory: run only the Event Hub cloud-account add and skip the directory
setup. Requires event_hub_onboarding or event_hub_onboarding_without_oauth.
