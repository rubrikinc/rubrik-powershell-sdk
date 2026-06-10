### PhoenixRolloutProgress
The Phoenix rollout progress.

- numNotEnabled: System.Int32
  - The number of objects that require migration and do not have Phoenix enabled.
- numInProcess: System.Int32
  - The number of objects that require migration and are in the process of enabling Phoenix.
- numEnabled: System.Int32
  - The number of objects that have Phoenix enabled.
- numIncompleteFirstFull: System.Int32
  - The number of objects that have not yet completed their first full snapshot.
