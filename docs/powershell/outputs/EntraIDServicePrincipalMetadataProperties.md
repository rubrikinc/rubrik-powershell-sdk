### EntraIDServicePrincipalMetadataProperties
EntraIDServicePrincipalMetadataProperties holds additional
properties for service principals. It also contains information about the
application's properties, if the service principal is internal.

- appId: System.String
  - Entra ID application ID that this service principal represents.
- appOwnerOrgId: System.String
  - Entra ID organization ID that owns the application.
- homepage: System.String
  - Homepage URL for the application.
- publisherName: System.String
  - Publisher name for the application.
- appOwners: list of EntraIDOwners
  - The owners of the application.
- hasForbiddenRole: System.Boolean
  - Specifies if the service principal has a forbidden role.
- applicationTemplateId: System.String
  - The gallery template ID from Microsoft App Gallery. Cross-tenant consistent
for gallery apps (e.g., Slack, Teams); empty for custom app registrations.
- hasNoActiveUserOwner: System.Boolean
  - Specifies if the linked Application Registration has no active user owner.
- isExternallyOwned: System.Boolean
  - Specifies if the service principal is owned by an external tenant (not
registered in the current customer tenant). True for Microsoft first-party
and third-party SaaS SPs; false for tenant-registered SPs and managed
identities.
- hasOwnPasswordCredential: System.Boolean
  - Specifies if the service principal has any password credential on its own
SP object (not on the owning application registration).
