### VmwareVirtualMachineResourceSpec
VMware virtual machine resource specification.

- workloadId: System.String
  - Workload ID.
- workloadName: System.String
  - Name of the workload.
- numCpus: System.Int32
  - Number of vCPUs assigned to the virtual machine.
- memoryMbs: System.Int32
  - Amount of memory in megabytes assigned to the virtual machine.
- osType: System.String
  - OS type of the virtual machine.
- storageVolumes: list of VmwareVirtualMachineVolumes
  - Storage volume configuration of the virtual machine.
- networkInterfaces: list of VmwareVirtualMachineNics
  - Network interface configuration of the virtual machine.
- isArchived: System.Boolean
  - Whether the workload is archived.
- snapshotId: System.String
  - Snapshot ID of the workload.
