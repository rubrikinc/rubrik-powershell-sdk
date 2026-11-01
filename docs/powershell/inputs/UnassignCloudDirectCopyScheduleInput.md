### UnassignCloudDirectCopyScheduleInput
Removes share-to-schedule links by assignment identifier.

- clusterUuid: System.String
  - Cluster UUID is the NCD cluster that owns the schedule and assignments.
- scheduleId: System.String
  - Schedule ID is the unique identifier of the schedule whose assignments to remove.
- assignmentIds: list of System.Strings
  - Assignment IDs are the unique identifiers of the (schedule, share) link
objects to remove, taken from the assignmentId field returned by the
assignments query. Removing an assignment unlinks only that share from the
schedule; the schedule and the share are unaffected.
