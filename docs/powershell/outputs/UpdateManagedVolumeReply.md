### UpdateManagedVolumeReply
Supported in v5.0+

- hostPatterns: list of System.Strings
  - Required. Supported in v5.0+
  v5.0-v5.3: List of host patterns. A host pattern describes a set of hosts who can mount the host. It can either be a host name, a network in CIDR notation or hostnames matching wildcards * or ?
  v6.0: List of host patterns. A host pattern describes a set of hosts who can mount the host. It can either be a host name, a network in CIDR notation or hostnames matching wildcards * or ?.
  v7.0: List of host patterns. A host pattern describes a set of hosts that can mount the host. It can either be a host name, a network in CIDR notation or hostnames matching wildcards *, or ?.
  v8.0+: List of host patterns. A host pattern describes a set of hosts that can mount the host. It can either be a host name, a network in CIDR notation or hostnames matching wildcards * or ?.
- isDeleted: System.Boolean
  - Required. Supported in v5.0+
  v5.0-v5.3: Indicates whether the managed volume is deleted
  v6.0: Indicates whether the managed volume is deleted.
  v7.0+: Indicates if the Managed Volume is deleted.
- isRelic: System.Boolean
  - Required. Supported in v5.0+
  v5.0-v6.0: Is managed volume a relic.
  v7.0+: Indicates if the Managed Volume is a relic.
- isWritable: System.Boolean
  - Required. Supported in v5.0+
  v5.0-v5.3: Indicates whether managed volume is open for writes
  v6.0: Indicates whether managed volume is open for writes.
  v7.0+: Indicates if the Managed Volume is open for writes.
- links: list of Links
  - Supported in v5.0+
  v5.0-v6.0: List of links for the managed volume.
  v7.0+: List of links for the Managed Volume.
- mainExport: ManagedVolumeExport
  - Supported in v5.0+
  v5.0-v8.0:
  v8.1+: The Main export of the Managed Volume.
- numChannels: System.Int32
  - Required. Supported in v5.0+
  v5.0-v6.0: Number of channels to divide the volume into. Each channel provides a unique share to write to.
  v7.0+: Number of channels to divide the Managed Volume into. Each channel provides a unique share for writing.
- pendingSnapshotCount: System.Int32
  - Required. Supported in v5.0+
  v5.0-v6.0: Combined total of in-progress snapshots and pending snapshots.
  v7.0+: Combined total of in-progress and pending snapshots.
- smbDomainName: System.String
  - Supported in v5.0+
  v5.0-v5.3: Valid Active Directory domain name for users accessing this managed volume over SMB
  v6.0: Valid Active Directory domain name for users accessing this managed volume over SMB.
  v7.0+: Valid Active Directory domain name for users accessing this Managed Volume over SMB.
- smbValidIps: list of System.Strings
  - Supported in v5.0+
  v5.0-v5.3: List of valid SMB host IP addresses that can access the SMB share for this managed volume. This parameter is required when the value of shareType is SMB
  v6.0: List of valid SMB host IP addresses that can access the SMB share for this managed volume. This parameter is required when the value of shareType is SMB.
  v7.0+: List of valid SMB host IP addresses that can access the SMB share for this Managed Volume. This parameter is required when the value of shareType is SMB.
- smbValidUsers: list of System.Strings
  - Supported in v5.0+
  v5.0-v5.3: List of valid usersnames in the domain that can access the SMB share for this managed volume. This parameter is required when the value of shareType is SMB
  v6.0: List of valid usersnames in the domain that can access the SMB share for this managed volume. This parameter is required when the value of shareType is SMB.
  v7.0+: List of valid usersnames in the domain that can access the SMB share for this Managed Volume. This parameter is required when the value of shareType is SMB.
- snapshotCount: System.Int32
  - Required. Supported in v5.0+
  Number of snapshots.
- subnet: System.String
  - Supported in v5.0+
  v5.0-v6.0: Specify the subnet associated with the managed volume.
  v7.0+: Specifies the subnet associated with the Managed Volume.
- usedSize: System.Int64
  - Required. Supported in v5.0+
  v5.0-v6.0: Used capacity for the volume across all the channels in bytes.
  v7.0+: Used capacity, in bytes, for the Managed Volume across all channels.
- volumeSize: System.Int64
  - Required. Supported in v5.0+
  v5.0-v6.0: Maximum capacity for the volume across all the channels in bytes.
  v7.0+: Maximum capacity, in bytes, for the Managed Volume across all channels.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v5.3+
  Describes any pending SLA Domain assignment on this object.
- applicationTag: ManagedVolumeApplicationTag
  - Application whose data this Managed Volume will store. For example, Oracle, SAP HANA, MSSQL, etc.
- mvType: CdmManagedVolumeType
  - Type of the Managed Volume (SlaBased / AlwaysMounted).
- shareType: ManagedVolumeShareType
  - Specifies if the Managed Volume is exported over NFS or SMB.
- state: ManagedVolumeState
  - Supported in v5.0+
  v5.0-v5.3: Managed volume state like exported, resetting etc.,
  v6.0: Managed volume state like exported, resetting etc.,.
  v7.0: State of the Managed Volume. For example, exported, resetting etc.
  v8.0+: State of the Managed Volume. For example, exported, resetting etc.,.
- slaManagedVolumeDetails: SlaManagedVolumeDetail
  - Supported in v5.3+
  The additional details specific to SLA Managed Volumes.
- snappable: CdmWorkload
  - The base workload object.
