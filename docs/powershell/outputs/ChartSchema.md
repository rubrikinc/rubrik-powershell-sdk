### ChartSchema
The chart schema that contains all available charts of the the report.

- attributeSets: list of ReportAttributeSets
  - The list of available chart attribute sets used to build the chart.
- measureSets: list of ReportMeasureSets
  - The list of available chart measure sets used to build the chart.
- invalidMatches: list of InvalidAttributeMeasureSetMatchs
  - The list of invalid matches of the attribute and measure sets used to build the chart.
- defaultChartConfigs: list of DefaultReportChartConfigs
  - Optional default chart configurations for new reports.
If empty, the UI will use the first attributeSet and the first measureSet as defaults.
