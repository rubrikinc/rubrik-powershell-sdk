### IdentityProvider
Identity Provider is an entity responsible for authenticating a user account.

- entityId: System.String
  - EntityId of the Identity provider.
- expirationDate: DateTime
  - Expiration date of the identity providers metadata.
- name: System.String
  - Name of the Identity provider.
- ownerOrgId: System.String
  - ID of the organization that owns the identity provider.
- signInUrl: System.String
  - URL of single sign-on endpoint.
- signOutUrl: System.String
  - URL of the single sign-out endpoint.
- spInitiatedSignInUrl: System.String
  - URL of service provider initiated single sign-on.
- spInitiatedTestUrl: System.String
  - URL of service provider initiated single sign-on for the purpose of testing a configured identity provider.
