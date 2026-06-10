### GitHubAppStatusInfo
Status-specific information for the GitHub App.

- registrationInfo: GitHubAppRegistrationInfo
  - Details if a new app needs to be registered.
This field is set if the app_status is NOT_REGISTERED or
MISSING_LATEST_PERMISSIONS.
- installationInfo: GitHubAppInstallationInfo
  - Details if the app is registered but not installed.
This field is set if the app_status is REGISTERED.
