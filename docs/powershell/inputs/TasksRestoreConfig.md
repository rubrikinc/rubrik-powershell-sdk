### TasksRestoreConfig
The Microsoft To Do tasks to be restored.

- tasksToRestore: list of TaskInfos
  - Task(s) to restore in this job. Each task's source_task_list_id must
reference a list in task_lists_to_restore so the destination list is
created before item restore begins.
- taskListsToRestore: list of TaskListRestoreInfos
  - Task list(s) to restore in this job. Supplies the folders to restore and
the source list names used to create the destination lists.
