### CloudDirectCopyScheduleAssignmentItem
A single share-to-schedule link.

- assignmentId: System.String
  - Assignment ID is the unique identifier of this share-to-schedule link.
- scheduleId: System.String
  - Schedule ID is the unique identifier of the schedule, matching the
scheduleId of the copy schedule.
- shareId: System.String
  - Share ID is the unique identifier of the NAS Cloud Direct share assigned
as a source for the schedule.
- clusterUuid: System.String
  - Cluster UUID is the NCD cluster that owns the schedule and share.
