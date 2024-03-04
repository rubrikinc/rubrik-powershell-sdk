### AuthorizedPrincipal
LDAP authorized principal.

- principalType: PrincipalTypeEnum
  - Principal Type.
- id: System.String
  - Principal ID
- authDomainId: System.String
  - ID of the authentication domain.
- authDomainName: System.String
  - Name of the authentication domain.
- name: System.String
  - Name of the principal.
- email: System.String
  - Email address.
- lastLogin: DateTime
  - Last login timestamp.
- totpStatus: LdapTotpStatus
  - TOTP status for a LDAP principal.
- lockoutStatus: LdapLockoutStatus
  - Lockout status for an LDAP principal.
- roles: list of Roles
- emailConfig: list of EventDigests
  - Email notification configurations.
