### UpdateBadDiskLedStatusInput


- diskSerial: System.String
  - Specifies the disk serial id.
- id: System.String
  - Required. ID of the Rubrik cluster or *me* for self.
- nodeId: System.String
  - Required. Node on which the script should be run.
- turnOff: System.Boolean
  - Specifies whether the off script flag should be used.
- isLightDiskLed: System.Boolean
  - Specifies whether to light the disk LED regardless of disk health status. When true, uses -LIGHT_DISK_LED instead of -SERIAL to locate disks in READY_TO_REMOVE state where error logs may have rolled over.
