### NutanixVirtualMachineResourceSpec
Nutanix virtual machine resource specification.

- workloadId: System.String
  - Workload ID.
- workloadName: System.String
  - Name of the workload.
- numCpus: System.Int32
  - The number of vCPUs to assign to the virtual machine.
- memoryMbs: System.Int32
  - The amount of memory, in megabytes, to assign to the virtual machine.
- osType: System.String
  - OS type of the virtual machine.
- storageVolumes: list of NutanixVirtualMachineVolumes
  - Storage volume configuration of the virtual machine.
- networkInterfaces: list of NutanixVirtualMachineNics
  - Network configuration of the virtual machine.
- isArchived: System.Boolean
  - Whether the workload is archived.
- snapshotId: System.String
  - Snapshot ID of the workload.
