### SailPointIntegrationConfig
Holds the configuration of the SailPoint integration.

- clientId: System.String
  - The OAuth client ID for authenticating with SailPoint ISC.
- baseUrl: System.String
  - The SailPoint ISC tenant base URL (e.g.
https://<tenant>.api.identitynow.com). The OAuth token URL is derived
from this base URL.
- status: SailPointStatus
  - The status of the integration.
