### CdmTotpStatusInternal
Supported in v5.3+

- lastUpdateTimeUtc: System.String
  - Last time the TOTP status was updated in UTC.
- isEnabled: System.Boolean
  - Required. Specifies whether TOTP is enabled for the user.
- isEnforced: System.Boolean
  - Required. Supported in v5.3+
Indicates whether the time-based one time password (TOTP) authentication method is being enforced. Returns true when TOTP is enforced and false when TOTP is not enforced.
