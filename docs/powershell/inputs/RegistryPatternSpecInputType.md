### RegistryPatternSpecInputType
RegistryPatternSpec describes one Windows registry key search pattern and
optional value-level predicates. Assigned a stable pattern_id UUID by
orion-hunt-service at hunt creation time (see design decision D6).

- keyPattern: System.String
  - Output-only: denormalized mirror of hive_root + key_path, populated by OHS
on create/update for downstream consumers that read this field. Not accepted
as an input; set hive_root and key_path instead.
- valueNames: list of System.Strings
  - Exact value name match. Callers set exactly one entry; kept as
`repeated` to pass the value name alongside the other predicates for a
single key in the same block.
- valueTypes: list of System.Strings
  - Deprecated: use valueTypeList for new hunts. Kept as a denormalized
mirror when valueTypeList is populated.
- valueDataEq: System.String
  - Case-insensitive exact equality match against value data.
- valueDataNotEq: System.String
  - Value data must not equal this string (case-insensitive).
- valueDataContains: System.String
  - Case-insensitive substring match against value data.
- valueDataNotContains: System.String
  - Substring must be absent from value data (case-insensitive).
- hiveRoot: RegistryHiveRoot
  - Structured registry root. When set, keyPath holds the root-relative path
and keyPattern is a derived mirror. Takes precedence over keyPattern.
- keyPath: System.String
  - Root-relative key path; required when hiveRoot is set.
- valueTypeList: list of RegistryValueTypes
  - Structured value-type filter; may hold multiple value types (OR
semantics), unlike valueNames above. Takes precedence over valueTypes
when non-empty.
