### GetTotpStatusReply
TOTP status for a user.

- isEnabled: System.Boolean
  - TOTP as 2FA is enabled.
- isEnforced: System.Boolean
  - TOTP as 2FA is enforced.
- totpReminderHours: System.Int32
  - Integer value indicating the period of showing TOTP configuration reminder in hours.
- totpConfigUpdateAt: DateTime
  - Timestamp of last TOTP configuration update.
- isSupported: System.Boolean
  - Specifies whether TOTP is supported for the user.
- isEnforcedUserLevel: System.Boolean
