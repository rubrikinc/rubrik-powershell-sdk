### SnapshotLocationView
Filter for per-location entries in snapshot retention info. Defaults to EXCLUDE_EXPIRED.

- EXCLUDE_EXPIRED - Exclude locations where snapshot is expired.
- EXCLUDE_EXPIRED_AND_TO_EXPIRE - Exclude locations where snapshot is expired or is going to expire.
- INCLUDE_EXPIRED - Include all locations including the ones where snapshot is already expired. Requires CDM 9.6.1+ on the source cluster - older CDMs do not emit expired per-location entries, so the response will contain only alive locations (the same set as EXCLUDE_EXPIRED), with no error. This view is gated on a per-account feature flag; if the account is not enabled, the request is rejected with an error.
