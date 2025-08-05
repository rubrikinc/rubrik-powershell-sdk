### GcpGetResourceSetupTemplateReq
GcpGetResourceSetupTemplateReq is the request to get the resource setup
Terraform templates.

- projectsWithFeatures: list of ProjectWithFeaturess
  - List of projects with features and permission groups to be onboarded.
- projectIdToServiceAccount: ProjectIdToServiceAccount
  - Mapping from the project to the service account with which the cloud calls
for the project should be made. The global service account will be used as
the default service account.
