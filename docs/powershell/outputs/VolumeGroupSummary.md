### VolumeGroupSummary
Supported in v5.0+

- hostId: System.String
  - Supported in v5.0+
  v5.0-v5.2: Id of the host of the volume group
  v5.3+: The unique ID of the host that contains the Volume Group.
- hostname: System.String
  - Supported in v5.0+
  v5.0-v5.2: IP Address or fully qualified domain name with which the host was added
  v5.3+: The name of the host that contains the Volume Group.
- id: System.String
  - Required. Supported in v5.0+
  v5.0-v5.2: 
  v5.3+: The unique ID of the Volume Group.
- isRelic: System.Boolean
  - Required. Supported in v5.0+
  v5.0-v5.2: Whether this Volume Group is currently accessible on the host
  v5.3+: Specifies whether the Volume Group is accessible on the Rubrik cluster.
- name: System.String
  - Required. Supported in v5.0+
  v5.0-v5.2: 
  v5.3+: The name of the Volume Group.
- forceFull: System.Boolean
  - Supported in v5.3+
  Specifies whether the Volume Group is set to take a full snapshot for the next backup.
- needsMigration: System.Boolean
  - Supported in v5.3+
  Specifies whether the Volume Group needs to be migrated in order to use the fast VHDX builder. This flag is set only when the Volume Group's last backup job failed due to an error during data fetch, and the backup job did not use the fast VHDX builder.
- snappable: CdmWorkload
  - 
