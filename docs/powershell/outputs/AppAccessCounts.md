### AppAccessCounts
Aggregated app access counts for a principal.

- directAppCount: System.Int32
  - Apps accessible directly (user -> app_role -> app).
- groupCount: System.Int32
  - Groups that grant app access.
- indirectAppCount: System.Int32
  - Apps accessible via groups (may overlap with direct_app_count).
