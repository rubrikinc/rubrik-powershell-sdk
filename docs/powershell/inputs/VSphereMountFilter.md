### VSphereMountFilter
Filter for virtual machine Live Mounts.

- name: System.String
  - Filters Live Mounts by name.
- clusterUuid: list of System.Strings
  - Filters Live Mounts by the UUIDs of the Rubrik clusters hosting them.
- powerStatus: list of System.Booleans
  - Filters Live Mounts by power status: true for powered on, false for
powered off.
- sourceVmId: System.String
  - Filters Live Mounts by the RSC ID of the source virtual machine.
