### ManagedVolumePatchConfigInput
Supported in v5.0+
  v5.0-v8.0: 
  v8.1+: Config for updating a Managed Volume.

- hostPatterns: list of System.Strings
  - Supported in v5.0+
      v5.0-v5.3: List of host patterns. A host pattern describes a set of hosts who can mount the host. It can either be a host name, a network in CIDR notation or hostnames matching wildcards * or ?
      v6.0: List of host patterns. A host pattern describes a set of hosts who can mount the host. It can either be a host name, a network in CIDR notation or hostnames matching wildcards * or ?.
      v7.0: List of host patterns. A host pattern describes a set of hosts that can mount the host. It can either be a host name, a network in CIDR notation or hostnames matching wildcards *, or ?.
      v8.0+: List of host patterns. A host pattern describes a set of hosts that can mount the host. It can either be a host name, a network in CIDR notation or hostnames matching wildcards * or ?.
- nodeHint: list of System.Strings
  - Supported in v5.0+
      v5.0-v6.0: List of node-ids to use for mounting this managed volume channels. Caller should specify at least one node per channel in the managed volume. If the nodeHint is not provided, system will randomly select a subset of nodes in cluster to mount the channels.
      v7.0+: List of node-IDs to use for mounting the channels of this Managed Volume. Caller should specify at least one node per channel in the Managed Volume. If nodeHint is not provided, the system randomly selects a subset of Rubrik cluster nodes to mount the channels.
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
- nfsSettings: ManagedVolumeNFSSettingsInput
  - Supported in v9.3+
      Settings related to NFS for the Managed Volume.
