### ConfigResource
Cloud configuration resource with common fields and resource-specific details.

- id: System.Int64
  - Unique rubrik resource ID.
- resourceType: ConfigResourceType
  - Resource type.
- resource: ApplicationResourceMetadata
  - Resource.
- metadata: System.String
  - Metadata containing additional resource information.
- specificResource: SpecificResource
  - Resource-specific details based on resource type.
