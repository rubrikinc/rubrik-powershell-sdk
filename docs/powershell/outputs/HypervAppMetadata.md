### HypervAppMetadata
Hyper-V virtual machine snapshot metadata.

- networkAdapters: list of HypervNetworkAdapters
  - Network adapters configured on the Hyper-V virtual machine.
- numVirtualCpus: System.Int32
  - Number of virtual processors configured on the Hyper-V virtual machine when the snapshot was taken.
- memoryMb: System.Int64
  - Memory, in MB, assigned to the Hyper-V virtual machine at startup when the snapshot was taken, rounded down to an even value. For virtual machines using dynamic memory this is the startup size, not the maximum.
