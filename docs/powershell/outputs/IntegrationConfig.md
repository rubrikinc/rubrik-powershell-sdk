### IntegrationConfig
Holds the configuration of a single integration. Note that IntegrationConfig
 can hold multiple configurations at once but only the configuration specified
 with IntegrationType will be considered.

- dataLossPrevention: DlpConfig
  - The Data Loss Prevention configuration.
- serviceNowItsm: ServiceNowItsmIntegrationConfig
  - The ServiceNow ITSM configuration.
