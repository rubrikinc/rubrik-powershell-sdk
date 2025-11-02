### ActiveDirectoryUserRestoreOptionsInput
Supported in v9.0+

- passwordOptions: ActiveDirectoryUserPasswordRecoveryOption
  - Supported in v9.0+
Options for the recovery of the user's password.
- shouldEnableUser: System.Boolean
  - Supported in v9.0+
Whether to enable the user after restore operation.
- shouldChangePassword: System.Boolean
  - Supported in v9.0+
Whether the user should be prompted to change the password upon their next login.
- password: System.String
  - Supported in v9.0+
Set the specified password for all users that have been restored.
