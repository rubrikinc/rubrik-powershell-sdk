### SlaAutoMigrationFsmState
This enum represents the states of a Finite State Machine (FSM) for an SLA Domain auto-migration campaign.

- START - This signifies the initial state of the SLA Domain auto-migration campaign.
- MANDATORY_PERIOD - This denotes the initial 30 days period post which the SLA Domains will be auto-migrated.
- GRACE_PERIOD - This represents the final 7 days period post which SLA Domains will be auto-migrated.
- AUTO_MIGRATION - This marks the period during which SLA Domains will be auto-migrated periodically.
- OPTED_OUT - This describes the state when the customer has opted out of the SLA Domain auto-migration campaign.
- END - This signifies the end of the SLA Domain auto-migration campaign.
