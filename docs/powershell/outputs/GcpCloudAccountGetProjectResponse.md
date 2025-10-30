### GcpCloudAccountGetProjectResponse
GcpCloudAccountGetProjectReply returns the GCP project details with the
cloud account information and feature status.

- project: GcpProject
  - The cloud account corresponding to the project containing all project
metadata, configuration, and authentication details.
- featureDetails: list of GcpFeatureDetails
  - Status of each enabled feature for the project including feature-specific
role information and current operational status.
- credentialsManagedBy: CredentialsManagedBy
  - Manager of the credentials.
