### GetTotpStatusReply
TOTP status for a user.

- isEnabled: System.Boolean
  - TOTP as 2FA is enabled.
- isEnforced: System.Boolean
  - TOTP as 2FA is enforced.
- isEnforcedUserLevel: System.Boolean
  - None
- isSupported: System.Boolean
  - Specifies whether TOTP is supported for the user.
- totpConfigUpdateAt: DateTime
  - Timestamp of last TOTP configuration update.
- totpReminderHours: System.Int32
  - Integer value indicating the period of showing TOTP configuration reminder in hours.
