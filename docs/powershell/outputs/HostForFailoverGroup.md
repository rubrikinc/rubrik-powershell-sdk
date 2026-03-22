### HostForFailoverGroup
Information about a host eligible for adding to a failover group.

- id: System.String
  - Host ID.
- name: System.String
  - Name of the host.
- rbsStatus: HostConnectivityStatus
  - RBS status of the host.
- osType: HostRegisterOsType
  - OS type of the host.
- isEligible: System.Boolean
  - Whether the host is eligible for adding to a failover group.
- ineligibilityReason: HostIneligibilityReason
  - Reason why the host is ineligible (if not eligible).
