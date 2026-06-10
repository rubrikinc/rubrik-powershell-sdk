### GitHubAppSetupInfo
Information about GitHub App setup for a specific purpose.

- appPurpose: PermissionsGroup
  - The purpose of this GitHub App.
- sessionId: System.String
  - Session ID for tracking the setup flow.
- appStatus: GitHubAppStatus
  - The current status of this GitHub App.
- statusInfo: GitHubAppStatusInfo
  - Status-specific details based on the current app status.
