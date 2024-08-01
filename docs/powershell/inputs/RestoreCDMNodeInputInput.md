### RestoreCDMNodeInputInput
Supported in v9.2+
  All the CDM Node inputs required for restoring.

- nodeHint: list of System.Strings
  - Supported in v9.2+
      List of Rubrik cluster node IDs to be used for mounting the channels associated with the workload. The caller must specify at least one node per channel. If the nodeHint is not provided, the system randomly selects a subset of Rubrik cluster nodes to mount the channels.
- subnet: System.String
  - Supported in v9.2+
      IP subnet specifying an outgoing VLAN interface for a Rubrik node. This is a required value when adding a workload on a Rubrik node that has multiple VLAN interfaces.
