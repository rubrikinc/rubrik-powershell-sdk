### PactsafeEulaState
End User License Agreement (EULA) state.

- bypassCheck: System.Boolean
  - Specifies whether the EULA should be bypassed.
- contractBase64: System.String
  - The EULA content in base-64 format.
- currentMajorVersion: System.String
  - The Pactsafe ID of the current major EULA contract version.
- currentVersion: System.String
  - The Pactsafe ID of the current EULA contract.
- deadline: DateTime
  - The deadline for a user account to accept the EULA before being locked out of RSC.
- downloadEndpoint: System.String
  - The URL to download the current EULA contract.
- effectiveDate: DateTime
  - Date when the most recent EULA was effective for the account.
- firstSeenTimestamp: DateTime
  - Timestamp when the current EULA was first seen by the account.
- isAuthorizedSigner: System.Boolean
  - Specifies whether the user can sign the EULA for the account.
- latestVersionAccepted: System.String
  - The Pactsafe ID of the latest contract major version accepted by the account.
- requiredEmailDomains: a list of System.Strings
  - The set of email domains that a user's email must belong to in order to sign the EULA for the account.
- title: System.String
  - The title of the EULA contract.
