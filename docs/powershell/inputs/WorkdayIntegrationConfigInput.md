### WorkdayIntegrationConfigInput
Holds the configuration of the Workday integration.

- clientId: System.String
  - The OAuth client ID for authenticating with Workday.
- clientSecret: System.String
  - The OAuth client secret for authenticating with Workday.
- refreshToken: System.String
  - The OAuth refresh token for maintaining the Workday connection.
- tokenEndpoint: System.String
  - The OAuth token endpoint URL for the Workday instance.
- status: WorkdayStatusInput
  - The status of the integration.
