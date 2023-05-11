### EnableDisableAppConsistencyInput
Input required to enable application consistent snapshots.

- enable: System.Boolean
  - Specifies whether to enable app consistency on VMs.
- objectType: CloudNativeVmAppConsistentObjectType
  - Object type for enabling app consistent protection.
- workloadIds: a list of System.Strings
  - List of virtual machine Rubrik IDs.
