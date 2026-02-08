### OpenstackCephSettingInput
Configuration settings for a Ceph storage backend in an OpenStack environment.

- id: System.String
  - Supported in v9.5+
The ID of the existing Ceph setting (if updating).
- fsid: System.String
  - Supported in v9.5+
The Ceph filesystem ID (optional).
- openstackAvailabilityZoneId: System.String
  - Required. Supported in v9.5+
The ID of the OpenStack availability zone.
- volumeTypeId: System.String
  - Required. Supported in v9.5+
The ID of the Ceph volume type.
- keyring: System.String
  - Supported in v9.5+
The Ceph keyring for authentication (optional).
- volumePoolName: System.String
  - Required. Supported in v9.5+
The name of the Ceph volume pool.
- monHosts: list of OpenstackMonHostInputs
  - Required. Supported in v9.5+
The list of Ceph monitor hosts.
