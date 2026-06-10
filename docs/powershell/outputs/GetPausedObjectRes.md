### GetPausedObjectRes
Provides information about a paused object.

- objectId: System.String
  - Represents the object ID of a paused object.
- objectName: System.String
  - Name of the paused object.
- objectType: ManagedObjectType
  - Represents the managed object type of a paused object.
- snappableHierarchyType: ManagedObjectType
  - Represents the workload hierarchy type of a paused object.
- pauseStartDate: DateTime
  - The time when the object was paused.
- pausedBy: System.String
  - Information about the person who issued the pause.
- note: System.String
  - User note, if any, stating the reason for the pause on the object.
- pendingPauseStatus: PendingObjectPauseAssignmentStatus
  - Pending pause assignment status for the object.
