### FusionComputeResourceSpec
FusionCompute resource specification captured at snapshot time.

- nics: list of FusionComputeNicSpecs
  - List of NIC specifications.
- numaNodes: System.Int32
  - Number of NUMA nodes configured for the virtual machine.
- vmCpuQuantity: System.Int32
  - Number of virtual CPUs.
- vmMemQuantityMb: System.Int64
  - Memory size in MB.
- vmProperties: FusionComputeVmProperties
  - Virtual machine properties (e.g., boot option).
