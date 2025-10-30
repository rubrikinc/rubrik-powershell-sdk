### SetCloudDirectGlobalSmbSettingsInput
Request for SetCloudDirectGlobalSmbSettings.

- clusterUuid: System.String
  - NCD cluster UUID.
- shouldSupportSystemFiles: System.Boolean
  - Whether to support system files.
Default value is false.
- offlineFilesBehaviour: CloudDirectOfflineFilesBehaviour
  - Mode for offline files.
Default value is SKIP.
