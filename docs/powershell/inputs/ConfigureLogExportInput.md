### ConfigureLogExportInput
Input for configuring the log export for a Managed Volume.

- id: System.String
  - Required. ID of the SLA Managed Volume.
- shouldEnableLogExport: System.Boolean
  - Required. Indicates the Rubrik cluster enables log export only if it is not already enabled. When set to true, this enables log streaming on the specified SLA Managed Volume. If log streaming is already enabled on the specified SLA Managed Volume, the API throws the LogStreamingAlreadyEnabled error. Currently, the Rubrik cluster does not support disabling log streaming by setting this flag to false. If you attempt to disable log streaming on the SLA Managed Volume when it is already enabled, the API throws the DisablingLogStreamingNotSupported error. If you attempt to disable log streaming on the SLA Managed Volume when it is not enabled, the API throws the LogStreamingNotEnabled error.
