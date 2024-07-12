### MssqlInstanceUpdateInput
Supported in v5.0+

- configuredSlaDomainId: System.String
  - ID of the SLA Domain assigned to the SQL Server instance.
- mssqlNonSlaProperties: MssqlNonSlaPropertiesInput
  - Supported in Rubrik cluster versions 4.0 and later. Non-SLA-Domain properties of a SQL Server database.
      In Rubrik cluster versions 5.2 and later, use 'MssqlSlaPatchProperties' instead.
      In Rubrik cluster versions 9.0 and later, use 'MssqlSlaRelatedProperties' instead.
- mssqlSlaPatchProperties: MssqlSlaPatchPropertiesInput
  - Supported in Rubrik cluster versions 5.2 and later. SLA Domain properties of a SQL Server database. In Rubrik cluster versions 9.0 and later, use 'MssqlSlaRelatedProperties' instead.
- mssqlSlaRelatedProperties: MssqlSlaRelatedPropertiesInput
  - Supported in Rubrik cluster versions 9.0 and later. Non-SLA-Domain properties of a SQL Server database.
