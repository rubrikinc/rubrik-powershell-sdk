### GenerateCdmTotpSecretInput
Input for generating TOTP secret for a user.

- id: System.String
  - Required. The user account object ID.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- reauthRequest: ReauthRequestInput
  - The reauthentication code to verify the user's identity.
