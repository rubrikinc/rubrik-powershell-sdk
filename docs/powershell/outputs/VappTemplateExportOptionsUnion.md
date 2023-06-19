### VappTemplateExportOptionsUnion
Supported in v5.1+
  Provides different options available for a vApp template snapshot export. Fields that correspond to unavailable choices are skipped.

- advancedExportOptions: VappTemplateExportOptions
  - Supported in v5.1+
  Organization VDC and storage profile choices available in case the advanced option of providing an organization vDC ID is used for export.
- defaultCatalogExportOptions: VappTemplateExportOptions
  - Supported in v5.1+
  Organization vDC and storage profile choices available in case the target catalog is used for export.
- originalVdcExportOptions: VappTemplateExportOptions
  - Supported in v5.1+
  Organization vDC and storage profile choices available in case original Organization vDC is used for export.
