### AssignmentResourceDetails
List of resource details.

- resourceId: System.String
  - ID of the resource.
- resourceName: System.String
  - Name of the resource.
- resourceType: DataGovObjectType
  - Type of the resource.
- isHigherLevelResource: System.Boolean
  - Boolean flag to signify whether the resource is a higher level resource.
- clusterUuid: System.String
  - UUID of the cluster that owns the resource. Empty for cluster and
hierarchy root resources.
- sddSchedule: SddSchedule
  - Sensitive data discovery schedule stored for the resource. Null when the
resource is not a Cloud Direct workload or has no schedule stored.
