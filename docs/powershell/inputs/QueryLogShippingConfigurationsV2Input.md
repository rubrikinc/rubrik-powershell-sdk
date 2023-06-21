### QueryLogShippingConfigurationsV2Input
Input for getting SQL Server log shipping configurations.

- limit: System.Int32
  - Limit the summary information to a specified maximum number of results.
- location: System.String
  - Filter log shipping configuration objects by performing an infix search using the location string value for a secondary database in the format "host/instance".
- offset: System.Int32
  - Starting position in the list of results contained in the response. The summary information includes the specified numbered result and all higher-numbered results.
- primaryDatabaseId: System.String
  - ID of a primary database object.
- primaryDatabaseName: System.String
  - Filter log shipping configuration objects by performing an infix search using the name of a primary database.
- secondaryDatabaseName: System.String
  - Filter log shipping configuration objects by performing an infix search using the name of a secondary database.
- sortBy: V2QueryLogShippingConfigurationsV2RequestSortBy
  - Attribute used to sort the results using an ASCII sort order. Sorts using the last_applied attribute represent the timestamp as an ISO 8601-encoded string.
- sortOrder: V2QueryLogShippingConfigurationsV2RequestSortOrder
  - Sort order, either ascending or descending.
- status: V2QueryLogShippingConfigurationsV2RequestStatus
  - Filter log shipping configuration objects based on the status value of the secondary database.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
