### CoordinatorLabel
Label that restricts a Cloud Direct virtual machine to a specific
class of tasks.

- RESTORE - Tasks for restore operations.
- BACKUP_SUITE - Tasks for backup operations.
- COPY - Tasks for copy operations.
- DISCOVER - Tasks for discovery operations.
- PAUSED - The coordinator is paused. No new tasks are dispatched while this
label is present. PAUSED may coexist with other labels -- unpausing
removes only this label, restoring the previous assignment.
