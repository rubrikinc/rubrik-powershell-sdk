### CreateMssqlLogShippingConfigurationInput
Input for creating a SQL Server log shipping configuration.

- config: MssqlLogShippingCreateConfigV2Input
  - Required. An object that contains the values of a log shipping configuration.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- id: System.String
  - Required. ID of the primary database object.
