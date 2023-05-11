### CreateGcpReaderTargetInput
Input for GCP Reader Target.

- archivalProxySettings: ProxySettingsInput
  - Field for creating proxy settings.
- bucket: System.String
  - Field for specifying GCP bucket name.
- bypassProxy: System.Boolean
  - Specifies whether the proxy settings should be bypassed for creating this target location.
- clusterUuid: System.String
  - Field for specifying cluster UUID of the target.
- encryptionPassword: System.String
  - Field for specifying encryption password.
- name: System.String
  - Field for specifying name of the target.
- readerRetrievalMethod: ReaderRetrievalMethod
  - Field for specifying the metadata to be retrieved from a target.
- region: GcpRegion
  - Field for specifying region of the target.
- serviceAccountJsonKey: System.String
  - Field for specifying service account JSON key.
- storageClass: GcpStorageClass
  - Field for specifying storage class of the target.
