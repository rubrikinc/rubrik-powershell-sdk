### CdmUserMetadata
CdmUserMetadata represents the metadata for the CDM user.

- id: System.String
  - ID of the user.
- email: System.String
  - Email address of the user.
- sshKey: System.String
  - SSH key of the user.
- sshKeyChangeTimestamp: DateTime
  - Timestamp when the SSH key was last changed.
- sshLoginEnabled: System.Boolean
  - Whether SSH login is enabled for the user.
- mfaEnabled: System.Boolean
  - Whether MFA is enabled for the user.
- lastLoginTimestamp: DateTime
  - Timestamp of the last login.
- lastPasswordResetTimestamp: DateTime
  - Timestamp of the last password reset.
- lastMfaConfigUpdateTime: DateTime
  - Timestamp of the last MFA configuration update.
