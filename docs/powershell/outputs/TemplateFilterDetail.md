### TemplateFilterDetail
Filter metadata for a report template. Dynamic values are not resolved.

- name: System.String
  - The filter identifier.
- displayName: System.String
  - The display name shown in the UI.
- isDynamic: System.Boolean
  - Whether the filter values are dynamic.
- staticValues: list of TemplateFilterValues
  - Static filter values. Empty if the filter is dynamic
and values must be retrieved separately.
