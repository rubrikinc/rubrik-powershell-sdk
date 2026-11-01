### ShareUnassignStatus
ShareUnassignStatus is the per-assignment outcome of an unassign operation.

- SHARE_UNASSIGN_STATUS_UNSPECIFIED - UNSPECIFIED is the zero value, reserved for forward compatibility.
- SHARE_UNASSIGN_STATUS_SUCCESS - SUCCESS indicates the assignment was successfully removed.
- SHARE_UNASSIGN_STATUS_NOT_ASSIGNED - NOT_ASSIGNED indicates no active link exists for this assignment.
- SHARE_UNASSIGN_STATUS_PERMISSION_DENIED - PERMISSION_DENIED indicates the caller is not authorized to assign copy schedules to the source share behind this assignment.
- SHARE_UNASSIGN_STATUS_INTERNAL_ERROR - INTERNAL_ERROR indicates an unexpected failure; see error_message.
- SHARE_UNASSIGN_STATUS_SHARE_NOT_FOUND - SHARE_NOT_FOUND indicates the share referenced by the assignment is gone.
- SHARE_UNASSIGN_STATUS_SCHEDULE_NOT_FOUND - SCHEDULE_NOT_FOUND indicates the assignment does not belong to the
specified schedule (it is linked to a different schedule, or the
schedule no longer exists).
- SHARE_UNASSIGN_STATUS_IN_USE - IN_USE indicates the assignment cannot be removed while the share is
actively in use by a running job.
