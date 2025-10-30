### AnalyzerGroupResult
AnalyzerGroupResult represents the result of a group of analyzers.

- analyzerGroup: AnalyzerGroup
  - Analyzer group.
- hits: Hits
  - Represent sensitive hits for the analyzer group.
- analyzerResults: list of AnalyzerResults
  - Analyzer results for the analyzer group.
- totalHits: Hits
  - Represents the total number of hits for the analyzer group,
including sensitive and non-sensitive hits.
