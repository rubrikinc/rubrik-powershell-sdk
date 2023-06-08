### SelfServicePermissionInput
When an org member adds an object to Rubrik that matches the provided (`inventoryRoot`, `inventoryWorkloadType`) category, the org is granted all permission operations specified within the `operations` field on that new object.

- inventoryRoot: InventorySubHierarchyRootEnum
  - The inventory hierarchy root to which this set of permissions will apply.
- inventoryWorkloadType: WorkloadLevelHierarchy
  - The inventory workload type to which this set of permissions will apply.
- operations: list of Operations
  - The operations granted to the org on newly added objects matching the provided `inventoryRoot` and `inventoryWorkloadType`.
