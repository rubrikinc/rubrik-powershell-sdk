### SetMfaSettingInput
MFA settings to update for an account.

- isTotpEnforcedGlobal: System.Boolean
  - Optional boolean value indicating whether TOTP is globally enforced. If omitted, existing value of the setting is kept.
- totpReminderHours: System.Int32
  - Optional integer value indicating the period of showing TOTP configuration reminder in hours. If omitted, existing value of the setting is kept.
- mfaRememberHours: System.Int32
  - Optional integer value indicating the time of remembering the MFA login in hours. If omitted, existing value of the setting is kept.
