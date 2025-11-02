### GcpProject
GcpProject represents a Google Cloud Platform (GCP) project within the
Rubrik platform.

- id: System.String
  - UUID in our customers used to represent the project within Rubrik.
- projectId: System.String
  - The native ID of a GCP project, which is a unique identifier assigned
by Google for the project.
- name: System.String
  - Human-readable name of the GCP project as configured in Google Cloud.
- projectNumber: System.Int64
  - Google-assigned numeric identifier for the project, which is immutable
and unique across all Google Cloud projects.
- roleId: System.String
  - Google managed ID of the role created in the GCP project for Rubrik
operations, used for permission management and access control.
- usesGlobalConfig: System.Boolean
  - Specifies if the global JWT config is used for authentication instead
of project-specific credentials.
- organizationName: System.String
  - Organization name of the GCP project. This field is optional and may
be empty if the project is not part of an organization.
- isArchived: System.Boolean
  - Specifies if the project is archived and no longer actively managed
by Rubrik operations.
- effectiveServiceAccount: System.String
  - The service account which will be applicable for making all the cloud
interaction calls. This comes directly from the applicable credentials
for the project and determines the identity used for GCP API calls.
- projectManagedObjectId: System.String
  - The managed object id of the project in the authz service.
