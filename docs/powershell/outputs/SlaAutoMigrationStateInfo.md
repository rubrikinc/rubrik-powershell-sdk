### SlaAutoMigrationStateInfo
An object for storing the state information related to the SLA Domain auto-migration campaign.

- state: SlaAutoMigrationFsmState
  - Current state of the SLA Domain auto-migration campaign.
- startDate: DateTime
  - Start date of the SLA Domain auto-migration campaign state.
- endDate: DateTime
  - End date of the SLA Domain auto-migration campaign state.
- pauseDate: DateTime
  - The date when the SLA Domain auto-migration campaign was paused.
- extensionGranted: System.Boolean
  - Indicates if a one-time extension was granted for the SLA Domain auto-migration campaign.
- extensionGrantedInCurrentState: System.Boolean
  - Indicates if a one-time extension was granted in the current state of the SLA Domain auto-migration campaign.
- successfullyMigrated: System.Boolean
  - Indicates if the SLA Domain auto-migration campaign was successfully completed with all SLA Domains switched over.
