### AccessTypeSummary
AccessTypeSummary includes a summary of counts of direct principals and IDs
of group and role-based principals, which provides access to sensitive data.

- directAccessCount: System.Int32
  - Count of permissions that give principal direct access to sensitive data.
- indirectAccessCount: System.Int32
  - Count of permissions that give principal access to sensitive data
through mechanisms other than direct access.
- accessViaGroupIds: list of System.Strings
  - List of group-based principal IDs through which this principal inherits
access to sensitive data.
- accessViaRoleIds: list of System.Strings
  - List of role-based principal IDs through which this principal inherits
access to sensitive data.
