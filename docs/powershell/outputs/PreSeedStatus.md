### PreSeedStatus
Pre-seed status of one workload on one recovery plan.

- snapshotId: System.String
  - Target-cluster snapshot the most recent pre-seed is for. Unset when it
cannot be resolved.
- state: PreSeedState
  - State of that pre-seed, corrected from the target cluster while it runs.
- progress: System.Single
  - Completion percentage (0-100) while RUNNING, when the target cluster
reports it.
- lastPreSeededSnapshotId: System.String
  - Target-cluster snapshot of the last pre-seed that succeeded: the snapshot
the standby is at. Unset when no pre-seed is known to have succeeded.
