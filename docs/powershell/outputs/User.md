### User
User account details.

- id: System.String
  - The user ID.
- email: System.String
  - The user's email address.
- domain: UserDomainEnum
  - The domain the user belongs to.
- lastLogin: DateTime
  - The last time the user logged in.
- status: UserStatus
  - The status of the user account.
- groups: list of System.Strings
  - The groups that the user belongs to.
- totpStatus: TotpStatus
  - The TOTP status of user.
- passkeyMetadata: PasskeyMetadata
  - The passkey metadata of the user.
- lockoutState: LockoutState
  - The user account lockout information.
- isHidden: System.Boolean
  - Specifies whether auth domain user is hidden.
- isAccountOwner: System.Boolean
  - Specifies whether user is an account owner.
- username: System.String
  - The user's username.
- unreadCount: System.Int64
  - The number of unread notifications for the current user.
- eulaState: EulaState
  - The user's EULA acceptance state.
- domainName: System.String
  - Name of the domain to which the SSO user belongs.
- lockoutHistory: list of UserLockoutEvents
  - The user account lockout history.
- assignedRoles: list of RoleAssignments
  - Roles assigned to the user.
- allOrgs: list of Orgs
  - The suborganizations in which the user has roles.
- emailConfig: list of EventDigests
  - Email notification configurations.
- roles: list of Roles
  - Roles assigned to the user.
