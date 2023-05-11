### VolumeGroupPatchInput
Supported in v5.0+

- configuredSlaDomainId: System.String
  - Supported in v5.0+
      v5.0-v5.2: Assign this Volume Group to the given SLA domain.
      v5.3+: The ID of the SLA Domain policy to assign to the Volume Group.
- forceFull: System.Boolean
  - Supported in v5.1+
      v5.1-v5.2: Boolean value that determines whether to force a full for the next snapshot of a volume group. Use true to force a full and false to use the default. The backup job resets the parameter to false after a successful full snapshot.
      v5.3+: Determines whether the next snapshot of the Volume Group is a full. After the snapshot has completed, this parameter will be reset to the default false value.
- isPaused: System.Boolean
  - Supported in v5.0+
      v5.0-v5.2: Whether backup/archival/replication is paused for this Volume Group
      v5.3+: Indicates whether backup, archival, and replicated is paused for this Volume Group.
- volumeIdsIncludedInSnapshots: a list of System.Strings
  - Supported in v5.0+
      v5.0-v5.2: IDs of the Volumes which we will include in snapshots. The volume must either currently exist on the host, or already be included in snapshots.
      v5.3: The unique ID of each volume included in the Volume. Group.
      v6.0+: The unique ID of each volume included in the Volume Group.
