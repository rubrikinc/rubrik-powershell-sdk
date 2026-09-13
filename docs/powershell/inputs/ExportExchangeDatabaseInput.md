### ExportExchangeDatabaseInput
Input for exporting a Microsoft Exchange database snapshot to a new location on a target Exchange host.

- id: System.String
  - Required. ID of the source Exchange database.
- config: ExportExchangeDbJobConfigInput
  - Required. Configuration for the export request.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
