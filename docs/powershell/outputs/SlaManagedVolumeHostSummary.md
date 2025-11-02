### SlaManagedVolumeHostSummary
Supported in v5.3+

- hostId: System.String
  - Required. Supported in v5.3+
v5.3: ID of the host mounting the managed volume channels and running the scripts
v6.0: ID of the host mounting the managed volume channels and running the scripts.
v7.0: ID of the host mounting the SLA Managed Volume channels and running the scripts.
v8.0+: ID of the host mounting the Managed Volume channels and running the scripts.
- hostName: System.String
  - Required. Supported in v5.3+
The name of the host on which the SLA Managed Volume channels are mounted.
- operatingSystemType: System.String
  - Required. Supported in v5.3+
The type of the operating system running on the host. Possible responses are `Linux`, `Windows` and `UnixLike`.
- rubrikBackupServiceStatus: System.String
  - Required. Supported in v5.3+
v5.3-v6.0: The status of the Rubrik Backup Service (RBS) installed on the managed volume host. Possible responses are `Connected`, `Disconnected` and `REPLICATION_TARGET` when the host is being replicated from a separate Rubrik cluster.
v7.0: Status of the Rubrik Backup Service (RBS) installed on the SLA Managed Volume host. Possible responses are `Connected`, `Disconnected`, and `REPLICATION_TARGET` when the host is being replicated from a separate Rubrik cluster.
v8.0+: Status of the Rubrik Backup Service (RBS) installed on the Managed Volume host. Possible responses are `Connected`, `Disconnected`, and `REPLICATION_TARGET` when the host is being replicated from a separate Rubrik cluster.
