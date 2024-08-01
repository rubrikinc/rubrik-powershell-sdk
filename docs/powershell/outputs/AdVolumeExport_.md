### AdVolumeExport
Active Directory volume export.

- isActive: System.Boolean
  - Specifies whether the export is active or not.
- internalTimestamp: System.Int64
  - Last updated time of the export.
- floatingIp: System.String
  - Floating IP address of the volume export.
- mountDir: System.String
  - Mount directory for the volume export.
- isUserVisible: System.Boolean
  - Determines if the export created is visible to user.
- domainControllerId: System.String
  - UUID of the corresponding domain controller.
- domainControllerName: System.String
  - Name of the corresponding domain controller.
- smbValidIps: list of System.Strings
  - The whitelisted IP addresses that can access Active Directory live mount.
- mountNodeIp: System.String
  - Mount Node IP address of the volume export. This IP address is preferred over floating IP address.
- id: System.String
  - Fid of the volume export.
- sourceSnapshot: CdmSnapshot
  - Source snapshot of the volume export.
- cluster: Cluster
  - Rubrik cluster of the volume export.
- node: ClusterNode
  - CDM node specification for the volume export.
