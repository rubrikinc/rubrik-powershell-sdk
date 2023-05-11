### CreateOrgInput
Details for creating a new organization.

- allowedClusters: a list of System.Strings
  - Allowed clusters for the organization.
- authDomainConfig: TenantAuthDomainConfig
  - Use the SSO/LDAP configuration of the global organization or set the configuration specific to this organization.
- description: System.String
  - Description for organization.
- existingSsoGroups: a list of ExistingSsoGroupInputs
  - Existing SSO groups to be authorized for this tenant organization.
- existingUsers: a list of ExistingUserInputs
  - Existing users to add to the tenant organization.
- fullName: System.String
  - Full name of the tenant organization.
- isEnvoyRequired: System.Boolean
  - Force organization to use envoy to connect their hosts.
- name: System.String
  - Unique name ID of the organization.
- newSsoGroups: a list of NewSsoGroupInputs
  - New SSO groups to be authorized for this tenant organization.
- permissions: a list of PermissionInputs
  - Permissions to be given to the org admin role.
- selfServicePermissions: a list of SelfServicePermissionInputs
  - Self-service permissions to be assigned to the organization.
- shouldEnforceMfaForAll: System.Boolean
  - Enforce MFA for all users in the organization.
- userInvites: a list of UserInviteInputs
  - Invitations to invite new users to the tenant organization.
