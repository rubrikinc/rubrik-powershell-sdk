### ManagedVolumeUpdateInput
Supported in v5.0+

- config: ManagedVolumePatchConfigInput
  - Supported in v5.0+
      v5.0-v8.0: 
      v8.1+: Config for updating a Managed Volume.
- configuredSlaDomainId: System.String
  - Supported in v5.0+
      v5.0-v5.1: Assign this managed volume to the given SLA domain.
      v5.2+: Assign this managed volume to the given SLA domain. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- name: System.String
  - Supported in v5.0+
      Change the name of this managed volume.
- volumeSize: System.Int64
  - Supported in v5.0+
      Increase capacity for the volume across all the channels.
- slaClientConfig: ManagedVolumePatchSlaClientConfigInput
  - Supported in v5.3+
- subnet: System.String
  - Supported in v5.3+
      Change the IP subnet that specifies an outgoing VLAN interface for a Rubrik node. This option is only available for SLA Managed Volumes.
