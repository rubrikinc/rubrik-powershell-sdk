# Invoke-RscMutateLdap
## Subcommands
### deletePrincipal
- The Input parameter takes a single value of type a list of System.Strings.
- Returns System.Boolean.
### removeIntegration
Remove LDAP integration.

- The Input parameter takes a single value of type System.String.
- Returns System.Boolean.
### setMfaSetting
Update the MFA settings for the given LDAP integration. Return true when the operation succeeds.

- The Input parameter takes a single value of type SetLdapMfaSettingInput.
- Returns System.Boolean.
### updateIntegration
Mutate LDAP integration.

- The Input parameter takes a hashtable with 13 name and value pairs.
    - baseDn - System.String: BaseDn for your LDAP integration.
    - bindUserName - System.String: BindUserName for your LDAP integration.
    - bindUserPassword - System.String: BindUserPassword for your LDAP integration.
    - dynamicDnsName - System.String: Dynamic DNS name for your LDAP integration.
    - groupMemberAttr - System.String: Group member attribute for your LDAP integration.
    - groupMembershipAttr - System.String: Group membership attribute for your LDAP integration.
    - groupSearchFilter - System.String: Group search filter for your LDAP integration.
    - id - System.String: ID for your LDAP integration.
    - ldapServers - a list of LdapServerInputs: LdapServers for your LDAP integration.
    - name - System.String: Name for your LDAP integration.
    - trustedCerts - System.String: TrustedCerts for your LDAP integration.
    - userNameAttr - System.String: User name attribute for your LDAP integration.
    - userSearchFilter - System.String: User search filter for your LDAP integration.
- Returns System.String.
