### O365TodoTask
A To Do task item.

- title: System.String
  - The title/subject of the task.
- status: System.String
  - The status of the task (e.g. "notStarted", "inProgress", "completed").
- importance: System.String
  - The importance of the task (e.g. "low", "normal", "high").
- dueDateTime: DateTime
  - The due date/time of the task.
- snapshotId: System.String
  - The snapshot ID of this version of the task.
- snapshotTime: DateTime
  - The snapshot time of this version of the task.
- snapshotNum: System.Int32
  - The snapshot number of this version of the task.
- categories: list of System.Strings
  - The categories associated with this task.
- id: System.String
  - The ID of the Microsoft 365 Exchange object.
- parentFolderId: System.String
  - The parent folder ID of the object (ROOT indicates root folder).
