### RefreshReaderTargetInput
Input for refreshing reader archival location.

- archivalDataSourceIds: a list of System.Strings
  - List of workload IDs on the original Rubrik cluster. This list should be empty for full refresh.
- clusterId: System.String
  - ID of the Rubrik cluster on which the reader archival location to be refreshed is created.
- externalLocationId: System.String
  - Rubrik CDM ID of the reader archival location to be refreshed. We need to pass clusterId with externalLocationId. We cannot use this field with locationId.
- localDataSourceIds: a list of System.Strings
  - List of workload IDs on the reader Rubrik cluster. This list should be empty for full refresh.
- locationId: System.String
  - ID of the reader archival location to be refreshed. We cannot use this field with externalLocationId.
