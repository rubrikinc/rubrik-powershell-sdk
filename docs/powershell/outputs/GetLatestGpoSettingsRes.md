### GetLatestGpoSettingsRes
GetLatestGpoSettingsRes is the response type for the latest GPO settings.

- gpoSettings: ActiveDirectoryGpoSettingsData
  - GPO settings data from the latest DC snapshot.
- uniformJson: System.String
  - Uniform JSON tree of GPO settings, suitable for structured UI rendering.
Populated only when return_uniform_json is true in the request.
Empty string if transformer fails (frontend falls back to raw XML).

The JSON is compact (no whitespace). Call JSON.parse() to get an object
with shape:
{
"name": "Computer Configuration",
"children": [
{
"name": "Policies",
"setting": "value",
"children": [...]
}
]
}

Each node has "name" (string) and optionally "setting" (string)
and "children" (array of nodes).
- snapshotTime: DateTime
  - Timestamp of the snapshot used, so UI can show "Settings as of {date}".
- versionNumber: System.Int32
  - Raw GPO version number from AD versionNumber attribute.
High 16 bits = user version, low 16 bits = computer version.
Nil/unset if lookup fails (graceful degradation).
