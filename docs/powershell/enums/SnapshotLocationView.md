### SnapshotLocationView
Filter for per-location entries in snapshot retention info. Defaults to EXCLUDE_EXPIRED.

- EXCLUDE_EXPIRED - Exclude locations where snapshot is expired.
- EXCLUDE_EXPIRED_AND_TO_EXPIRE - Exclude locations where snapshot is expired or is going to expire.
- INCLUDE_EXPIRED - Include all locations including the ones where snapshot is already expired. NOT YET SUPPORTED: passing this value returns an error until backend support is added.
