### CreateGcpReaderTargetInput
Input for GCP Reader Target.

- clusterUuid: System.String
  - Field for specifying cluster UUID of the target.
- name: System.String
  - Field for specifying name of the target.
- region: GcpRegion
  - Field for specifying region of the target.
- storageClass: GcpStorageClass
  - Field for specifying storage class of the target.
- bucket: System.String
  - Field for specifying GCP bucket name.
- encryptionPassword: System.String
  - Field for specifying encryption password.
- serviceAccountJsonKey: System.String
  - Field for specifying service account JSON key.
- archivalProxySettings: ProxySettingsInput
  - Field for creating proxy settings.
- readerRetrievalMethod: ReaderRetrievalMethod
  - Field for specifying the metadata to be retrieved from a target.
- archivalDataSourceIds: list of System.Strings
  - List of workload IDs on the original Rubrik cluster. This list should be empty for a full refresh.
- bypassProxy: System.Boolean
  - Specifies whether the proxy settings should be bypassed for creating this target location.
