# Invoke-RscMutateLdap
## Subcommands
### Deleteprincipal
- There is a single argument of type list of System.Strings.
- Returns System.Boolean.
### Removeintegration
Remove LDAP integration.

- There is a single argument of type System.String.
- Returns System.Boolean.
### Setmfasetting
Update the MFA settings for the given LDAP integration. Return true when the operation succeeds.

- There is a single argument of type SetLdapMfaSettingInput.
- Returns System.Boolean.
### Updateintegration
Mutate LDAP integration.

- There are 13 arguments.
    - id - System.String: ID for your LDAP integration.
    - name - System.String: Name for your LDAP integration.
    - bindUserName - System.String: BindUserName for your LDAP integration.
    - bindUserPassword - System.String: BindUserPassword for your LDAP integration.
    - baseDn - System.String: BaseDn for your LDAP integration.
    - trustedCerts - System.String: TrustedCerts for your LDAP integration.
    - dynamicDnsName - System.String: Dynamic DNS name for your LDAP integration.
    - ldapServers - list of LdapServerInputs: LdapServers for your LDAP integration.
    - userSearchFilter - System.String: User search filter for your LDAP integration.
    - userNameAttr - System.String: User name attribute for your LDAP integration.
    - groupMembershipAttr - System.String: Group membership attribute for your LDAP integration.
    - groupSearchFilter - System.String: Group search filter for your LDAP integration.
    - groupMemberAttr - System.String: Group member attribute for your LDAP integration.
- Returns System.String.
