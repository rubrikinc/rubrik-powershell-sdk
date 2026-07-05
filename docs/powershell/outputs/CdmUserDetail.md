### CdmUserDetail
Supported in v5.0+

- id: System.String
  - Required. Supported in v5.0+
- createdById: System.String
  - Required. Supported in v5.0+
- userType: CdmUserType
  - Supported in v7.0+
The type of user.
- sshKey: System.String
  - Supported in v6.0+
v6.0-v9.2: SSH key used for Rubrik cluster login.

v9.3+: SSH public key used for authorizing Rubrik cluster logins.
- lastName: System.String
  - Supported in v5.0+
- totpStatus: CdmTotpStatusInternal
  - Supported in v5.3+
- lastPasswordResetTimeUtc: System.String
  - Last time the user's password was reset, in UTC.
- firstName: System.String
  - Supported in v5.0+
- mfaServerId: System.String
  - Supported in v5.0+
- authDomainId: System.String
  - Required. Supported in v5.0+
- createTime: System.String
  - Required. Supported in v5.0+
- lastSshKeyUpdateTimeUtc: System.String
  - Last time the user's SSH key was updated, in UTC.
- contactNumber: System.String
  - Supported in v5.0+
- status: CdmUserAccountStatus
  - Supported in v5.1+
- username: System.String
  - Required. Supported in v5.0+
- emailAddress: System.String
  - Supported in v5.0+
- lastLoginTimeUtc: System.String
  - Last time the user logged in, in UTC.
