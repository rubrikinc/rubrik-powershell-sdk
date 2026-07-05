### AnalyzerAccessUsage
Analyzer access usage data.

- analyzer: Analyzer
  - Analyzer details.
- count: System.Int32
  - Sum of top files may not be equal to count.
- countDelta: System.Int32
  - Change in the count relative to the previous period.
- topFiles: list of FileAccessResults
  - Top files contributing to this analyzer's access usage.
