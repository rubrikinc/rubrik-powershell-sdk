### TotpStatus
TOTP status for a user.

- isEnforced: System.Boolean
  - Specifies whether TOTP is enforced.
- isEnforcedUserLevel: System.Boolean
  - Specifies whether TOTP is enforced at the user level.
- isEnabled: System.Boolean
  - Specifies whether TOTP is enabled for the user.
- isSupported: System.Boolean
  - Specifies whether TOTP is supported for the user.
- totpConfigUpdateAt: DateTime
  - The timestamp of the last TOTP configuration update.
- mfaStatus: UserMfaStatus
  - The MFA configuration status of the user.
