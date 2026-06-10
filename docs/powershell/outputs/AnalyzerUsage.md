### AnalyzerUsage
Captures the inverse relationship of which policies are using an analyzer.

- analyzer: Analyzer
  - Analyzer whose policy usages are described by this entry.
- policies: list of ClassificationPolicySummarys
  - Policies that reference this analyzer.
- dataTypeHits: DataTypeHits
  - Total sensitive hits in this data type.
- dataTypeSource: DataTypeSource
  - Represents the source of data type i.e PREDEFINED or CUSTOM.
