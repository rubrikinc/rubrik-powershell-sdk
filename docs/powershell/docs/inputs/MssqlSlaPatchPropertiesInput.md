### MssqlSlaPatchPropertiesInput
Supported in v5.1+

- configuredSlaDomainId: System.String
  - Supported in v5.1+
      v5.1: SLA Domain ID assigned to instance.
      v5.2+: SLA Domain ID assigned to instance. Existing snapshots of the instance will be retained with the configuration of specified SLA Domain.
- useConfiguredDefaultLogRetention: System.Boolean
  - Supported in v5.3+
      Determines whether to use the configured default value of log backup retention.
- mssqlSlaRelatedProperties: MssqlSlaRelatedPropertiesInput
  - Non-SLA-Domain properties of a SQL Server object.
