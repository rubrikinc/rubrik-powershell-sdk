### AssignCloudDirectCopyScheduleInput
Links source shares to an existing copy schedule.

- clusterUuid: System.String
  - Cluster UUID is the NCD cluster that owns the schedule and shares.
- scheduleId: System.String
  - Schedule ID is the unique identifier of the schedule to link shares to.
- shareIds: list of System.Strings
  - Share IDs are the unique identifiers of the NAS Cloud Direct shares to
link to the schedule as sources.
