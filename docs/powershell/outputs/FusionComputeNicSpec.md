### FusionComputeNicSpec
FusionCompute NIC specification.

- name: System.String
  - Display name of the NIC.
- urn: System.String
  - URN of the NIC.
- uri: System.String
  - URI of the NIC.
- portGroupUrn: System.String
  - URN of the port group the NIC is attached to.
- portGroupName: System.String
  - Display name of the port group the NIC is attached to.
- mac: System.String
  - MAC address of the NIC.
- ip: System.String
  - Primary IP address of the NIC.
- ipList: System.String
  - Comma-separated list of all IP addresses on the NIC.
- sequenceNum: System.Int32
  - Sequence number (slot index) of the NIC.
- ips6: list of System.Strings
  - List of IPv6 addresses on the NIC.
