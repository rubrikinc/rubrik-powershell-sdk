### ProtectedObjectTypeToPauseStatus
Represents a protected object type of an Azure resource group and the pause
status of that workload in the group.

- protectedObjectType: WorkloadLevelHierarchy
  - The type of the protected object.
- objectPauseStatus: ObjectPauseStatus
  - Pause status of the workload in the resource group.
- rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus
  - Pending pause or unpause assignment for the workload in the resource group.
