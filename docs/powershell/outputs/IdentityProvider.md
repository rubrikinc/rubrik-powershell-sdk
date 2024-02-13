### IdentityProvider
Identity Provider is an entity responsible for authenticating a user account.

- name: System.String
  - Name of the Identity provider.
- signInUrl: System.String
  - URL of single sign-on endpoint.
- entityId: System.String
  - EntityId of the Identity provider.
- spInitiatedSignInUrl: System.String
  - URL of service provider initiated single sign-on.
- spInitiatedTestUrl: System.String
  - URL of service provider initiated single sign-on for the purpose of testing a configured identity provider.
- signOutUrl: System.String
  - URL of the single sign-out endpoint.
- ownerOrgId: System.String
  - ID of the organization that owns the identity provider.
- metadataJson: System.String
  - Metadata of the identity provider in JSON format.
- signingCertificate: System.String
  - Signing certificate of the identity provider.
- expirationDate: DateTime
  - Expiration date of the identity providers metadata.
