### O365OauthConsentKickoffInput
Configuration for the kickoff of an OAuth consent flow.

- orgId: System.String
  - UUID of the org.
- appType: System.String
  - Type of the Azure app.
- resourceId: System.String
  - Rubrik Security Cloud ID of the Microsoft 365 resource [Deprecated pls switch to resourceIds].
- resourceIds: list of System.Strings
  - Rubrik Security Cloud IDs of the Microsoft 365 resources.
