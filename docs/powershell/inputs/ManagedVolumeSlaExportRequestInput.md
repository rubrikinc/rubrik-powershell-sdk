### ManagedVolumeSlaExportRequestInput
Supported in v7.0+
v7.0-v8.0:
v8.1+: Request object for creating an SLA Managed Volume export.

- shouldDownloadToLocal: System.Boolean
  - Supported in v7.0+
Specifies if the snapshot should be downloaded to local when not available locally.
- managedVolumeSlaExportConfig: ManagedVolumeSlaExportConfigInput
  - Configuration for an SLA Managed Volume Export.
- locationId: System.String
  - Supported in v9.4+
ID of the location from which the snapshot must be downloaded for export.
