### UpdateGcpTargetInput
Input for editing the GCP Target.

- id: System.String
  - Id of the GCP target to be edited.
- name: System.String
  - Name of the GCP target.
- region: GcpRegion
  - Region of the GCP target.
- storageClass: GcpStorageClass
  - Storage class of the GCP target.
- bucket: System.String
  - Bucket of the GCP target.
- encryptionPassword: System.String
  - Encryption password for the GCP target.
- serviceAccountJsonKey: System.String
  - Service account JSON key of the GCP target.
- archivalProxySettings: ProxySettingsInput
  - Proxy settings of the GCP target.
- bypassProxy: System.Boolean
  - Specifies whether the proxy settings should be bypassed for creating this target location.
