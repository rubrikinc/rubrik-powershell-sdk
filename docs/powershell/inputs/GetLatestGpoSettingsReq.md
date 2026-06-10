### GetLatestGpoSettingsReq
GetLatestGpoSettingsReq is the request type to get the latest GPO settings
from the most recent DC snapshot, without requiring a change event.

- gpoFid: System.String
  - FID of the GPO principal (from userawareness_principals).
- shouldReturnXml: System.Boolean
  - Controls the format of the raw settings data.
When false and return_uniform_json is false, returns HTML.
When true and return_uniform_json is false, returns XML.
When return_uniform_json is true, returns JSON regardless of this flag.
- returnUniformJson: System.Boolean
  - When true, also return the GPO settings as a uniform JSON tree
with friendly names, suitable for structured UI rendering.
The raw data field is omitted unless should_return_xml is also true.
- jsonDisplayFieldsOnly: System.Boolean
  - When true and return_uniform_json is also true, strip the raw name
and value fields from each node, returning only friendly_name,
display_value, and children. Has no effect when return_uniform_json
is false.
