### DiskStatus
Supported in v5.0+

- diskType: System.String
  - Required. Supported in v5.0+
- id: System.String
  - Required. Supported in v5.0+
- isDegraded: System.Boolean
  - Required. Supported in v5.0+
- isEncrypted: System.Boolean
  - Required. Supported in v5.0+
- nodeId: System.String
  - Required. Supported in v5.0+
- status: System.String
  - Required. Supported in v5.0+
- raidStatus: System.String
  - Supported in v9.4+
RAID status of the disk (NONE, OPTIMAL, READY_TO_REBUILD, REBUILDING, DEGRADED, OFFLINE).
- raidRebuildingPercentage: System.Single
  - Supported in v9.4+
RAID rebuilding percentage (0-100) when RAID status is REBUILDING.
- manufacturer: System.String
  - Supported in v9.4+
The manufacturer of the disk.
- raidType: System.String
  - Supported in v9.4+
RAID type of the disk (RAID0, RAID1).
- diskMode: System.String
  - Disk mode of the disk. One of DATA, METADATA, BOOT, UNPARTITIONED, or UNKNOWN.
- raidError: System.String
  - Supported in v9.4+
RAID error message if any.
- hasIndicatorLed: System.Boolean
  - Denotes whether a specific disk supports an admin-controllable indicator LED.
- modelNumber: System.String
  - Supported in v9.4+
The model number of the disk.
- serialNumber: System.String
  - Supported in v9.4+
The serial number of the disk.
