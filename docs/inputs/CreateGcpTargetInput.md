### CreateGcpTargetInput
Input for creating a GCP archival target.

- archivalProxySettings: ProxySettingsInput
  - Proxy settings of the GCP archival target.
- bucket: System.String
  - Bucket of the GCP archival target.
- bypassProxy: System.Boolean
  - Specifies whether the proxy settings should be bypassed for creating this archival target location.
- clusterUuid: System.String
  - Cluster UUID of the GCP archival target.
- encryptionPassword: System.String
  - Encryption password for the GCP archival target.
- name: System.String
  - Name of the GCP archival target.
- region: GcpRegion
  - Region of the GCP archival target.
- serviceAccountJsonKey: System.String
  - Service account JSON key for the GCP archival target.
- storageClass: GcpStorageClass
  - Storage class of the GCP archival target.
