### SegregatedFETBConsumption
6 segregation buckets: (active/relic) × (Protected/DoNotProtect/NoSla)

- protectedActive: System.Int64
  - Protected active (non-archived) objects
- notProtectedActive: System.Int64
  - Not protected active (non-archived) objects
- noSlaActive: System.Int64
  - No SLA active (non-archived) objects
- protectedRelic: System.Int64
  - Protected relic objects
- notProtectedRelic: System.Int64
  - Not protected relic objects
- noSlaRelic: System.Int64
  - No SLA relic objects
