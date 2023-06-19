### CdpVmInfo
The details about a CDP virtual machine.

- vmId: System.String
  - ID.
- vmName: System.String
  - Name.
- vmLocation: System.String
  - VCenter address.
- sourceCluster: System.String
  - Source cluster name.
- replicationTarget: System.String
  - Replication cluster name.
- slaDomainName: System.String
  - SLA Domain ID.
- latestSnapshotTime: DateTime
  - Latest snapshot time.
- cdpLocalStatus: CdpLocalStatus
  - Local status.
- cdpReplicationStatus: CdpReplicationStatus
  - Replication status.
- ioFilterStatus: IoFilterStatus
  - IO Filter installation status.
