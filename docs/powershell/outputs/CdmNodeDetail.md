### CdmNodeDetail
The node details of a Rubrik CDM cluster.

- nodeId: System.String
  - Rubrik cluster node ID.
- clusterId: System.String
  - Rubrik cluster UUID.
- dataIpAddress: System.String
  - Data IP address of the Rubrik cluster node.
- ipmiIpAddress: System.String
  - IPMI IP address of the Rubrik cluster node. Not available for virtual or cloud cluster nodes.
- dataAndManagementVlans: DataAndManagementVlans
  - Data and management VLANs of the Rubrik cluster node.
- networkZoneId: System.String
  - Network zone ID of this node. Absent if the node has no zone assignment.
- networkZoneName: System.String
  - Human-readable name of the network zone.
Absent if the zone has no name configured.
