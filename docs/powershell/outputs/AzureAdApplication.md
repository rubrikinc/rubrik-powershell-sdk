### AzureAdApplication
Entra ID application.

- displayName: System.String
  - Display name of the Entra ID application.
- appId: System.String
  - App ID of the Entra ID application.
- createdDateTime: DateTime
  - Created date and time of the Entra ID application.
- secretsExpired: System.Boolean
  - Specifies if the secrets of the Entra ID application have expired.
- appRoles: list of AzureAdAppRoles
  - List of App Roles associated with the Entra ID application.
- appRolesCount: System.Int32
  - Number of App Roles associated with the Entra ID application.
- linkedServicePrincipal: EntraIdLinkedServicePrincipal
  - Service principal that shares the app ID of the Entra ID application.
Absent when the tenant has no service principal for the application.
