### CreateO365AppKickoffInput
Configuration for O365 Azure AD App creation kickoff.

- appType: System.String
  - Type of app to create.
- orgId: System.String
  - UUID of the org.
- accessMode: M365AccessMode
  - Desired permission mode for the app created during this kickoff.
Defaults to full permissions when unset.
