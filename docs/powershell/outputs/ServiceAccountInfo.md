### ServiceAccountInfo
Supported in v9.2+
  The details of the RSC service account.

- serviceAccountName: System.String
  - Required. Supported in v9.2+
  The name of the RSC service account.
- accessToken: System.String
  - Required. Supported in v9.2+
  The access token for the service account.
- isK8SError: System.Boolean
  - Supported in v9.4+
  There was an error when fetching the service account secret from the Kubernetes cluster.
- clientId: System.String
  - Required. Supported in v9.2+
  The client ID for the service account.
