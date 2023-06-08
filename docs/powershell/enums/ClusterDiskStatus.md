### ClusterDiskStatus
Enum representing the cluster's knowledge of a disk state.

- ACTIVE - Mounted disk.
- REMOVED - Disk explicitly removed from the cluster.
- REPAIR - Disk is under repair (e.g., fsck) and is not available. The expectation is that the disk will become available soon but is not guaranteed. Both read and write operations will not be allowed in this status.
- UNFORMATTED - Disk with no ext4 partitions.
- MISSING - Disk present in node table but not on the node.
- PRE_REPAIR - Disk needs software repair (e.g, fsck) and is not writable.
- READY_TO_REMOVE - Disk finished draininig. User can unplug the disk.
- PRE_REMOVAL - Disk needs replacement. The disk is still readable but SDFS will drain the data gradually in the background.
- FAILED - Mounted disk continuously failing health checks.
- LOCKED - Self encrypting disk in locked state (only for appliances supporting hardware encryption).
- UNKNOWN - Unused.
