### TenantAuthDomainConfig
Specifies whether to use the SSO/LDAP configuration of the global organization or to use configuration specific to this organization.

- AUTH_DOMAIN_UNSPECIFIED - Auth domain configuration unspecified.
- ALLOW_AUTH_DOMAIN_CONTROL - Allows the tenant to set its own SSO/LDAP configuration.
- INHERIT_AUTH_DOMAIN - Uses the global org's SSO/LDAP configuration.
- LOCAL_AUTH_DOMAIN_ONLY - Only local users allowed.
