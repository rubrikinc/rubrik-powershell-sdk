### PreSeedState
State of a workload's most recent pre-seed.

- PRE_SEED_STATE_UNSPECIFIED - Never returned for a pre-seed record.
- PRE_SEED_STATE_PENDING - The pre-seed job is queued and has not started.
- PRE_SEED_STATE_RUNNING - The pre-seed job is copying data to the target cluster.
- PRE_SEED_STATE_SUCCEEDED - The pre-seed completed; the standby is at the pre-seed's snapshot.
- PRE_SEED_STATE_FAILED - The pre-seed failed, was cancelled or was rolled back.
