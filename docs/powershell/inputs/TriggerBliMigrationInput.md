### TriggerBliMigrationInput
TriggerBLIMigrationReq is the request object for triggering blob level
immutability migration for a list of RCV Azure locations.

- locationIds: list of System.Strings
  - List of location ids for which the migration is to be triggered.
- skipLocationsWithInProgressJobs: System.Boolean
  - Indicates whether to skip locations with backup and
archive jobs that are in progress.
