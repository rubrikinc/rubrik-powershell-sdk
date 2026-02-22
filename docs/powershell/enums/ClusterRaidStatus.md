### ClusterRaidStatus
Enum representing the RAID status for disks.

- NONE - Disk is not part of any RAID array.
- OPTIMAL - RAID array is operational and fully redundant.
- READY_TO_REBUILD - RAID array is ready to rebuild but needs reboot to start.
- REBUILDING - RAID array is actively restoring redundancy.
- DEGRADED - RAID array has lost redundancy due to drive failure/removal.
- OFFLINE - RAID array is inaccessible or offline due to multiple failures.
