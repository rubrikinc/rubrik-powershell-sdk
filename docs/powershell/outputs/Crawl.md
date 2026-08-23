### Crawl
A single on-demand classification scan (crawl) over a set of workloads,
including its lifecycle status, progress, and aggregate classification
results.

- id: System.String
  - Unique identifier of the crawl.
- name: System.String
  - Human-readable name of the crawl.
- status: CrawlStatusEnum
  - Current lifecycle status of the crawl.
- progress: System.Single
  - Fraction of the crawl completed, from 0.0 to 1.0.
- startTime: System.Int64
  - Start time of the crawl, in epoch seconds.
- endTime: System.Int64
  - End time of the crawl, in epoch seconds. Zero while the crawl is running.
- filesTotal: System.Int64
  - Total number of files discovered by the crawl.
- filesAnalyzeable: System.Int64
  - Number of files eligible for classification analysis.
- filesAnalyzed: System.Int64
  - Number of files that have been analyzed so far.
- filesWithHits: System.Int64
  - Number of analyzed files that had at least one classification hit.
- analyzerResults: list of AnalyzerResults
  - Per-analyzer classification result counts for the crawl.
- analyzerGroupResults: list of AnalyzerGroupResults
  - Per-analyzer-group classification result counts for the crawl.
- totalHits: System.Int32
  - Total number of classification hits across all analyzers.
- failedObjectCount: System.Int32
  - Number of workloads that failed to be crawled.
- dataCategoryIds: list of System.Strings
  - Data category IDs selected for the crawl at Start time. Populated only on
the single-crawl read path (GetCrawl) for v2 crawls; empty on the list
path and for v1 crawls.
- crawlObjConnection: CrawlObjConnection
  - The per-workload crawl objects in this crawl.
- crawlObj: CrawlObj
  - A single per-workload crawl object in this crawl.
- fileResultConnection: FileResultConnection
  - Browses the file classification results in this crawl.
- user: User
  - The user who started this crawl.
- snappableTypeSummaries: list of SnappableTypeSummarys
  - Per-workload-type summary counts for this crawl.
