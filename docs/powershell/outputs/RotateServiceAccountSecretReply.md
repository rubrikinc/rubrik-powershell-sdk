### RotateServiceAccountSecretReply
Updated service account details.

- clientId: System.String
  - ID of the service account.
- clientSecret: System.String
  - Secret used to authenticate to the authorization server.
- name: System.String
  - Name of the service account.
- accessTokenUri: System.String
  - URI to retrieve the access token.
- suspendedTprPolicyIds: list of System.Strings
  - IDs of the quorum authorization policies whose service account
exemptions were suspended by this rotation.
