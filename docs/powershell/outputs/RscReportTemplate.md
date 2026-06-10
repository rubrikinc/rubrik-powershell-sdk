### RscReportTemplate
A pre-defined report configuration template.

- reportViewType: PolarisReportViewType
  - The type of report view this template represents.
- name: System.String
  - Name suggested for this report template.
- description: System.String
  - Report description.
- filters: list of TemplateFilterDetails
  - Filters available for this template.
- tables: list of TemplateTableDetails
  - Available tables with their columns.
- chartSchema: ChartSchema
  - Available charts with valid attributes and measures sets,
invalid matches, and defaults.
