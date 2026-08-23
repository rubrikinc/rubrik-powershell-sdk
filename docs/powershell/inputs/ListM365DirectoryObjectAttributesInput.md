### ListM365DirectoryObjectAttributesInput
Configuration for the retrieval or directory object attributes.

- orgId: System.String
  - Microsoft 365 organization ID identifying the customer's M365 tenant.
- objectType: DirectoryObjectType
  - The directory object type applicable for attributes.
- attributeType: AttributeType
  - The attribute type definitions to retrieve. For more information, see https://learn.microsoft.com/en-us/graph/extensibility-overview.
- searchTextPrefix: System.String
  - Attribute definitions prefixes that you must match.
- maxResults: System.Int32
  - The maximum number of attributes to retrieve.
