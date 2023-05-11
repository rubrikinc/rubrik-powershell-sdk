### AuthorizedPrincipal
LDAP authorized principal.

- authDomainId: System.String
  - ID of the authentication domain.
- authDomainName: System.String
  - Name of the authentication domain.
- email: System.String
  - Email address.
- id: System.String
  - Principal ID
- lastLogin: DateTime
  - Last login timestamp.
- name: System.String
  - Name of the principal.
- principalType: PrincipalTypeEnum
  - Principal Type.
- roles: a list of Roles
  - None
- totpStatus: LdapTotpStatus
  - TOTP status for a LDAP principal.
