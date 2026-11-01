### ShareAssignStatus
ShareAssignStatus is the per-share outcome of an assign operation.

- SHARE_ASSIGN_STATUS_UNSPECIFIED - UNSPECIFIED is the zero value, reserved for forward compatibility.
- SHARE_ASSIGN_STATUS_SUCCESS - SUCCESS indicates the share was successfully linked to the schedule.
- SHARE_ASSIGN_STATUS_NOT_FOUND - NOT_FOUND indicates the share does not exist on the cluster.
- SHARE_ASSIGN_STATUS_ALREADY_ASSIGNED - ALREADY_ASSIGNED indicates the share is already linked to this schedule.
- SHARE_ASSIGN_STATUS_PERMISSION_DENIED - PERMISSION_DENIED indicates the caller is not authorized to assign copy schedules to this source share.
- SHARE_ASSIGN_STATUS_INTERNAL_ERROR - INTERNAL_ERROR indicates an unexpected failure; see error_message.
