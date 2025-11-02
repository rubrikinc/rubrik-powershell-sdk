### VolumeGroupDetailInfo
Supported in v9.2+

- id: System.String
  - Required. Supported in v9.2+
The unique ID of the Volume Group.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v9.2+
Describes any pending SLA Domain assignment on this object.
- isPaused: System.Boolean
  - Required. Supported in v9.2+
Indicates whether backup, archival, and replication are paused for this Volume Group.
- configuredSlaDomainId: System.String
  - Required. Supported in v9.2+
The ID of the SLA Domain policy to assign to the Volume Group.
- volumes: list of HostVolumeSummarys
  - Required. Supported in v9.2+
Configuration details for the volumes in the Volume Group.
