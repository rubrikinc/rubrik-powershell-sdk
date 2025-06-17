### InstanceProperties
InstanceProperties represents common properties across cloud providers.

- instanceType: System.Int32
  - Numeric identifier for the instance type.
- vendor: VendorType
  - Cloud vendor that offers this instance type.
- vcpuCount: System.Int32
  - Number of virtual CPUs (vCPUs) available on this instance type.
- memoryGib: System.Int32
  - Amount of memory in GiB available on this instance type.
- capacityTb: System.Int32
  - Storage capacity in TB available on this instance type.
- processorType: ProcessorType
  - Type of processor (Intel, AMD) used by this instance type.
- vmType: VmType
  - Virtual machine density, Standard, Dense, or Extra Dense for this instance type.
