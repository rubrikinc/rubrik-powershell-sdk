### IntegrationConfigInput
Holds the configuration of a single integration. Note that IntegrationConfig
 can hold multiple configurations at once but only the configuration specified
 with IntegrationType will be considered.

- dataLossPrevention: DlpConfigInput
  - The Data Loss Prevention configuration.
- serviceNowItsm: ServiceNowItsmIntegrationConfigInput
  - The ServiceNow ITSM configuration.
- okta: OktaIntegrationConfigInput
  - The OKTA configuration.
