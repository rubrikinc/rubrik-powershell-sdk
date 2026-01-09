### ManagedVolumeConfigInput
Supported in v5.0+
v5.0-v8.0:
v8.1+: Managed Volume Config.

- applicationTag: ManagedVolumeApplicationTag
  - Supported in v5.0+
v5.0-v6.0: Application whose data will be stored by this managed volume, like - Oracle, SAP Hana, MS SQL, etc.
v7.0+: Application whose data this Managed Volume will store. For example, Oracle, SAP Hana, MS SQL, etc.
- exportConfig: ManagedVolumeExportConfigInput
  - Required. Supported in v5.0+
v5.0-v8.0:
v8.1+: Config for a Managed Volume Export.
- name: System.String
  - Required. Supported in v5.0+
v5.0-v6.0: Name of the managed volume.
v7.0: Name of the Managed Volume.
v8.0+: Name of the managed volume.
- numChannels: System.Int32
  - Supported in v5.0+
v5.0-v6.0: Number of channels to divide the volume into. Each channel provides a unique share to write to.
v7.0+: Number of channels to divide the Managed Volume into. Each channel provides a unique share for writing.
- subnet: System.String
  - Supported in v5.0+
v5.0-v5.3: IP subnet that specifies an outgoing VLAN interface for a Rubrik node. This is a required value when creating a managed volume on a Rubrik node that has multiple VLAN interfaces
v6.0: IP subnet that specifies an outgoing VLAN interface for a Rubrik node. This is a required value when creating a managed volume on a Rubrik node that has multiple VLAN interfaces.
v7.0: IP subnet specifying an outgoing VLAN interface for a Rubrik node. This is a required value when creating a Managed Volume on a Rubrik node that has multiple VLAN interfaces.
v8.0+: IP subnet specifing an outgoing VLAN interface for a Rubrik node. This is a required value when creating a Managed Volume on a Rubrik node that has multiple VLAN interfaces.
- volumeSize: System.Int64
  - Required. Supported in v5.0+
v5.0-v6.0: Maximum capacity for the volume across all the channels.
v7.0+: Maximum capacity for the Managed Volume across all channels.
- mvType: CdmManagedVolumeType
  - Supported in v5.3+
v5.3-v8.0:
v8.1+: Type of the Managed Volume (SlaBased / AlwaysMounted).
- slaClientConfig: SlaManagedVolumeClientConfigInput
  - Supported in v5.3+
- filesystemType: ManagedVolumeFilesystemType
  - Supported in v9.5+
Type of filesystem used internally for the Managed Volume Stack.
