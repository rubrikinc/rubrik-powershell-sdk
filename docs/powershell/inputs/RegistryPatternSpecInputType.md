### RegistryPatternSpecInputType
RegistryPatternSpec describes one Windows registry key search pattern and
optional value-level predicates. Assigned a stable pattern_id UUID by
orion-hunt-service at hunt creation time (see design decision D6).

- keyPattern: System.String
  - Full HKLM\...\* or HKCU\...\* key path, validated on intake.
- valueNames: list of System.Strings
  - Exact value name match; or semantics across list entries.
- valueTypes: list of System.Strings
  - Exact registry type match; or semantics across list entries.
Allowed values: REG_SZ, REG_DWORD, REG_QWORD, REG_BINARY,
REG_EXPAND_SZ, REG_MULTI_SZ, REG_NONE.
- valueDataEq: System.String
  - Case-insensitive exact equality match against value data.
- valueDataNotEq: System.String
  - Value data must not equal this string (case-insensitive).
- valueDataContains: System.String
  - Case-insensitive substring match against value data.
- valueDataNotContains: System.String
  - Substring must be absent from value data (case-insensitive).
