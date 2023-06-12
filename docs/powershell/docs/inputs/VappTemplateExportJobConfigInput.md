### VappTemplateExportJobConfigInput
Supported in v5.1+

- storagePolicyId: System.String
  - Supported in v5.1+ ID of the storage policy of the organization vDC used to create the template. When this field is absent, the default from the organization vDC is used.
- catalogId: System.String
  - Required. Supported in v5.1+
      ID of the target catalog.
- name: System.String
  - Required. Supported in v5.1+
      Name of vApp template.
- orgVdcId: System.String
  - Required. Supported in v5.1+
      ID of the target organization vDC.
