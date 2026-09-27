### O365App
Configuration for a Microsoft 365 App.

- appId: System.String
  - The ID of the O365 app.
- subscriptionId: System.String
  - The ID of the O365 subscription.
- subscription: System.String
  - The subscription to which the O365 app is associated.
- appType: System.String
  - The type of the O365 app (e.g. ONEDRIVE).
- appOwner: System.String
  - The owner of the O365 app (RUBRIK or CUSTOMER).
- addedAt: DateTime
  - The added time of the O365 app.
- isAuthenticated: System.Boolean
  - The authentication status of the app against the subscription [To be deprecated].
- appAuthStatus: AppAuthStatus
  - The authentication status of the app against the subscription.
- appAuthVersion: System.Int32
  - The authentication version of the app against the subscription.
- accessMode: M365AccessMode
  - Baseline permission mode for the app. Every app is on full permissions
today; JIT mode selection is not yet available.
- credsState: AppCredsState
  - The state of the app credentials.
