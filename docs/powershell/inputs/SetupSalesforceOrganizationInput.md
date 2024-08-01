### SetupSalesforceOrganizationInput
Configuration for the protection and storage of a Salesforce organization in RSC.

- orgNaturalId: System.String
  - The natural ID of the Salesforce organization.
- orgName: System.String
  - Name of the Salesforce organization.
- slaDomainId: System.String
  - The ID of the SLA domain to apply to the Salesforce organization.
- storageRegion: System.String
  - The region where data is to be processed and stored for the Salesforce organization.
- apiLimits: SalesforceApiLimits
  - The API limits to be configured against the Salesforce organization in RSC.
- environmentType: SaasEnvironmentType
  - The environment type of the Salesforce organization.
