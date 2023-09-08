### UpdateVolumeGroupReply
Supported in v5.0+

- configuredSlaDomainId: System.String
  - Required. Supported in v5.0+
  v5.0-v5.2: Assign this Volume Group to the given SLA domain.
  v5.3+: The ID of the SLA Domain policy to assign to the Volume Group.
- isPaused: System.Boolean
  - Required. Supported in v5.0+
  v5.0-v5.2: Whether backup/archival/replication is paused for this Volume Group
  v5.3+: Indicates whether backup, archival, and replication are paused for this Volume Group.
- volumeGroupSummary: VolumeGroupSummary
  - Summary information about a volume group.
- volumes: list of HostVolumeSummarys
  - Required. Supported in v5.0+
  v5.0-v5.2:
  v5.3+: Configuration details for the volumes in the Volume Group.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v5.3+
  Describes any pending SLA Domain assignment on this object.
- blackoutWindowResponseInfo: BlackoutWindowResponseInfo
  - Blackout window information.
