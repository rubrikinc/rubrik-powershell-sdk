### AzureAuthType
AzureAuthType is the authentication method an Azure subscription was
onboarded with. AZURE_AUTH_TYPE_UNSPECIFIED is returned for a discovered
subscription that is not yet onboarded.

- AZURE_AUTH_TYPE_UNSPECIFIED - The subscription is not yet onboarded, so no authentication method
applies.
- AZURE_AUTH_TYPE_OAUTH_RUBRIK_APP - Onboarded with Rubrik's multi-tenant OAuth application.
- AZURE_AUTH_TYPE_OAUTH_CUSTOMER_APP - Onboarded with the customer's own OAuth application (national clouds).
- AZURE_AUTH_TYPE_NON_OAUTH - Onboarded without OAuth; the customer created the app and service
principal manually.
