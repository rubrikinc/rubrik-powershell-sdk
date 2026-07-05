### TimelineEntry
A single day's classification result counts for a policy timeline.

- day: System.String
  - Day in ISO date format YYYY-MM-DD.
- policyId: System.String
  - Policy ID, optionally populated when entry does not represent a policy.
- hits: Hits
  - Sensitive-hit counts for the day.
