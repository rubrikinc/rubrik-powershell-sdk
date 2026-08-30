### TaskInfo
The Microsoft To Do task to be restored.

- taskId: System.String
  - ID of the task to be restored.
- snapshotId: System.String
  - ID of the snapshot from which to restore.
- snapshotNum: System.Int32
  - Number of the snapshot from which to restore.
- sourceTaskListId: System.String
  - ID of the source task list the task belonged to at backup time. It is
resolved to a destination list before item restore begins.
