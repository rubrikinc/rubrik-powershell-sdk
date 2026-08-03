### NativeTagFilterParams
Params for filtering by raw native tags from an external source
system. Source-agnostic so future native tag sources (vCenter, etc.)
work without API churn.

- source: NativeTagSource
  - Source system that owns the native tags.
- nativeTagIds: list of System.Strings
  - Stable IDs of the native tags in the source system. Relationship
between IDs is OR.
