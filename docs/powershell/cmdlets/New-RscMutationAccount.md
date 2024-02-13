# New-RscMutationAccount
## Subcommands
### createorg
Create a new organization under global org.

- There is a single argument of type CreateOrgInput.
- Returns CreateOrgReply.
### createorgswitchsession
Generate a new authentication token for a user to switch organizations.

- There is a single argument of type CreateOrgSwitchSessionInput.
- Returns CreateOrgSwitchSessionReply.
### createrole
This endpoint is deprecated.

- There are 3 arguments.
    - name - System.String
    - description - System.String
    - permissions - list of PermissionInputs: Permissions in the role.
- Returns System.String.
### createuser
- There are 2 arguments.
    - email - System.String
    - roleIds - list of System.Strings
- Returns System.String.
### createuserwithpassword
- There is a single argument of type CreateUserWithPasswordInput.
- Returns System.String.
### deleteorg
Delete an organization.

- There is a single argument of type DeleteOrgInput.
- Returns System.Boolean.
### deleterole
- There is a single argument of type System.String.
- Returns System.Boolean.
### deletetotpconfig
Reset TOTP configuration for a user. Return true when the operation succeeds.

- There is a single argument of type System.String.
- Returns System.Boolean.
### deletetotpconfigs
Reset TOTP configuration for users in batch. Return true when the operation succeeds.

- There is a single argument of type DeleteTotpConfigsInput.
- Returns System.Boolean.
### deleteusers
- There is a single argument of type list of System.Strings.
- Returns System.Boolean.
### generatetotpsecret
Generate TOTP secret for a user.

- There is a single argument of type System.String.
- Returns GenerateTotpSecretReply.
### mutaterole
- There are 5 arguments.
    - roleId - System.String: ID of the role.
    - name - System.String
    - description - System.String
    - permissions - list of PermissionInputs: Permissions in the role.
    - protectableClusters - list of System.Strings
- Returns System.String.
### updateorg
Update an organization.

- There is a single argument of type UpdateOrgInput.
- Returns UpdateOrgReply.
### updaterole
This endpoint is deprecated.

- There are 4 arguments.
    - roleId - System.String: ID of the role.
    - name - System.String
    - description - System.String
    - permissions - list of PermissionInputs: Permissions in the role.
- Returns System.Boolean.
