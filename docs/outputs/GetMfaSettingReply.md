### GetMfaSettingReply
MFA settings for an account.

- isTotpEnforcedGlobal: System.Boolean
  - Boolean value indicating whether TOTP is globally enforced.
- isTotpGlobalEnforceLocked: System.Boolean
  - Boolean value indicating whether TOTP global enforcement is locked.
- isTotpMandatory: System.Boolean
  - Specifies whether TOTP is mandatory.
- mandatoryTotpEnforcementDate: DateTime
  - Specifies the date when TOTP enforcement becomes mandatory.
- mfaRememberHours: System.Int32
  - Integer value indicating the time of remembering the MFA login in hours.
- totpReminderHours: System.Int32
  - Integer value indicating the period of showing TOTP configuration reminder in hours.
