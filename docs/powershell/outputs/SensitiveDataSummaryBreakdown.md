### SensitiveDataSummaryBreakdown
SensitiveDataSummaryBreakdown contains the breakdown of the sensitive data
summary. The breakdown is grouped by policy, analyzer, mip label and
document type.

- sensitiveFiles: SensitiveFiles
  - Sensitive files breakdown by risk level (high, medium, low, total, no-risk)
with both total and violated counts for each category.
- dataCategories: list of PolicySummaryDetailss
  - List of data categories and hits summary for each based on the filter.
- dataTypes: list of AnalyzerResults
  - List of data types and hits summary for each based on the filter.
- mipLabels: list of MipLabelSummarys
  - List of mip labels and hits summary for each based on the filter.
- documentTypes: list of DocumentTypeSummarys
  - List of document types and hits summary for each based on the filter.
- dataTypeStats: list of DataTypeStatss
  - List of data types and hits summary for each based on the filter.
- dataCategoryStats: list of DataCategoryStatss
  - List of data categories and hits summary for each based on the filter.
