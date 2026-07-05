### UpdateCdmUserInfoInput
Supported in v5.0+

- sshKey: System.String
  - Supported in v6.0+
v6.0-v9.2: SSH key used for Rubrik cluster login.

v9.3+: SSH public key used for authorizing Rubrik cluster logins.
- lastName: System.String
  - Supported in v5.0+
- firstName: System.String
  - Supported in v5.0+
- mfaServerId: System.String
  - Supported in v5.0+
- password: System.String
  - Supported in v5.0+
- isTotpEnforced: System.Boolean
  - Supported in v5.3+
Indicates whether the time-based one time password (TOTP) authentication method is being enforced. Returns true when TOTP is enforced and false when TOTP is not enforced.
- contactNumber: System.String
  - Supported in v5.0+
- emailAddress: System.String
  - Supported in v5.0+
