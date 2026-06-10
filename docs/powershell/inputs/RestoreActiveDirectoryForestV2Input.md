### RestoreActiveDirectoryForestV2Input
RestoreActiveDirectoryForestV2Req is the request for initiating
an Active Directory Forest Restore job with streamlined input.

- forestConfig: ForestRecoveryGlobalConfig
  - Forest-level recovery configuration.
- domainConfigs: list of DomainRecoveryInputs
  - List of per-domain recovery configurations.
Each domain contains its DCs to recover and hosts to promote.
