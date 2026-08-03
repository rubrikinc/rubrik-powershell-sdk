### EntraIDUserMetadataProperties
EntraIDUserMetadataProperties holds additional properties for EntraID users.

- onPremSid: System.String
  - The on-premises security identifier (SID) of the user.
- mfaStrength: MfaStrength
  - Indicates the strength of MFA for the user.
- pwdLastSet: System.Int64
  - Last password set time in seconds in Unix time.
- shadowAdmins: list of EntraIdUserShadowMetadataAdminPropertiess
  - Holds information about the shadow admins of the user.
- terminatedEmployee: System.Boolean
  - Specifies if the user is a terminated employee.
