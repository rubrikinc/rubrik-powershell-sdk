### BulkUpdateSystemConfigInput
Input for updating configuration of multiple SAP HANA systems in bulk.

- systemIds: list of System.Strings
  - Required. Supported in v9.5+
The system IDs for which the configuration values have to be updated.
- isForceFullOnMasterChangeEnabled: System.Boolean
  - Supported in v9.5+
Whether to enable or disable taking a full backup after master failover.
