### SDDLPermission
Resolved permission for a single principal on a path.

- cn: System.String
  - Common name.
- dn: System.String
  - Distinguished name.
- access: System.String
  - Access level granted, e.g. full control, read, write.
- accessType: AceQualifier
  - Access type.
- flags: list of AceFlagss
  - The AceFlags value returned by sddl-service is the result of ORing
together all of the ACE's flags. We unpack these values from the response
and return a list of flags.
- resolutionType: ResolutionType
  - Describes whether the SID for this ACE was resolved, and if so, how
(by matching a well-known SID, querying AD, etc.).
- principalType: PrincipalRiskySummaryPrincipalType
  - The type of the principal (user, group, etc.).
- accessMethodDetails: DatagovAccessMethodDetailsType
  - The details of how the principal can access the path.
- principalId: System.String
  - The principalID that this ACE applies to.
- idpType: IdpType
  - The type of identity provider the principal belongs to.
- principalOrigin: PrincipalOrigin
  - Specifies whether the principal is internal or external to the organization.
