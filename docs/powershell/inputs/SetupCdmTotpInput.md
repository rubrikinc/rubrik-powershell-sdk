### SetupCdmTotpInput
Input for setting up TOTP for a user.

- id: System.String
  - Required. The user account object ID.
- configRequest: TotpConfigUpdateRequestInput
  - Required. The time-based one time password (TOTP) configuration.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
