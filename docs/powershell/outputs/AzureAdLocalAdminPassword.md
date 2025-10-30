### AzureAdLocalAdminPassword
Entra ID local administrator password.

- deviceName: System.String
  - Name of the device where this local administrator account exists.
- accountName: System.String
  - Name of the local administrator account.
- accountSid: System.String
  - Security Identifier (SID) of the local administrator account.
- password: System.String
  - Current password for the local administrator account.
- lastBackupDateTime: DateTime
  - Date and time when the password was last rotated/backed up to Entra ID.
- refreshDateTime: DateTime
  - Date and time when the password is scheduled for next rotation.
