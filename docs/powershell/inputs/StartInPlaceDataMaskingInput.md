### StartInPlaceDataMaskingInput
Request message for the StartInPlaceDataMasking API.

- destinationOrgId: System.String
  - ID of the SaaS organization to be masked.
- maskingTemplateId: System.Int64
  - ID of the masking template to be applied.
- disableAutomations: System.Boolean
  - Flag to turn off automations during the masking process.
- shouldChooseDefaultsOnMetadataMismatch: System.Boolean
  - When true, records rejected because a field became required in
Salesforce after the snapshot was taken are retried with default values
filled for the missing fields.
