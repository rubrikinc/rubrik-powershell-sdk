### GcpCloudAccountProject
GCP Cloud Account Project.

- id: System.String
  - Rubrik ID of the GCP project.
- projectId: System.String
  - Native ID of the GCP Project.
- name: System.String
  - Name of the GCP project.
- projectNumber: System.Int64
  - Native Project Number of the GCP Project.
- roleId: System.String
  - Google managed ID of the role created in the GCP project.
- usesGlobalConfig: System.Boolean
  - Whether the GCP project uses global configuration for authentication.
- organizationName: System.String
  - The name of the organization containing the GCP Project.
- isArchived: System.Boolean
  - Specifies if the project is archived.
- effectiveServiceAccount: System.String
  - Service account that will be used to make cloud calls for this project.
- projectManagedObjectId: System.String
  - The managed object id of the project in the authz service.
