### CrawlObj


- crawlId: System.String
- snapshotFid: System.String
- snapshotTime: System.Int64
- status: SnappableCrawlStatus
- progress: System.Single
- startTime: System.Int64
- endTime: System.Int64
- filesTotal: System.Int64
- filesAnalyzeable: System.Int64
- filesAnalyzed: System.Int64
- filesWithHits: System.Int64
- analyzerResults: list of AnalyzerResults
- analyzerGroupResults: list of AnalyzerGroupResults
- error: System.String
- totalHits: System.Int32
- fileResultConnection: FileResultConnection
  - Browses the file classification results within this crawl object.
- cluster: Cluster
  - The cluster that ran this crawl object's scan.
- snappable: HierarchyObject
  - The hierarchy object this crawl object scanned.
