### Hits
Hit statistics including total hits, violations, and permitted hits.

- totalHits: System.Int64
  - Sum of all hits.
- violations: System.Int64
  - Sum of hits not permitted by allowlist.
- permittedHits: System.Int64
  - Sum of hits permitted by allowlist.
- totalHitsDelta: System.Int64
  - Represents the change in total hits between the current
result and a previous result.
The interval of change may depend on the endpoint returning the result.
- violationsDelta: System.Int64
  - Represents the change in violation between the current
result and a previous result.
The interval of change may depend on the endpoint returning the result.
- permittedHitsDelta: System.Int64
  - Represents the change in permitted hits between the current
result and a previous result.
The interval of change may depend on the endpoint returning the result.
