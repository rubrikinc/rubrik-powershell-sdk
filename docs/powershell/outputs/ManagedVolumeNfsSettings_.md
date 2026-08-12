### ManagedVolumeNfsSettings
NFS settings and configurations for the Managed Volume.

- version: System.String
  - NFS version to be used for Managed Volume mounts.
- isTlsEnabled: System.Boolean
  - Whether NFSv4 mounts use TLS. Returns null for pre-v9.7 Rubrik clusters or managed volumes not configured with TLS.
