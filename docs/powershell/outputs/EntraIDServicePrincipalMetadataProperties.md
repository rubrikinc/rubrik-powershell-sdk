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
