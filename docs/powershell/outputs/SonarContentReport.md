### SonarContentReport
A single row in the content classification report, aggregating classification
results for a file, object, policy, analyzer, cluster, SLA Domain, or time
bucket depending on the requested grouping.

- id: System.String
  - Identifier for the report row, whose value depends on the groupBy: workload
ID and path for file, workload ID for object name, SLA Domain ID for SLA
Domain, policy ID for policy, analyzer ID for analyzer, Rubrik cluster ID
for Rubrik cluster, and timestamp for time.
- fileName: System.String
  - Name of the file this row represents, when grouped by file.
- path: System.String
  - Full path of the file, when grouped by file.
- hits: Hits
  - Classification hit counts for this row.
- analyzerGroupResults: list of AnalyzerGroupResults
  - Per-analyzer-group classification result counts for this row.
- analyzerResults: list of AnalyzerResults
  - Per-analyzer classification result counts for this row.
- snappableFid: System.String
  - Identifier of the workload this row belongs to.
- snapshotTimestamp: System.Int64
  - Snapshot time of the crawled data, in epoch seconds.
- cluster: System.String
  - Identifier of the Rubrik cluster, when grouped by cluster.
- size: System.Int64
  - Size of the file in bytes, when grouped by file.
- filesWithHits: System.Int32
  - Number of files with classification hits in this row.
- slaDomainId: System.String
  - Identifier of the SLA Domain, when grouped by SLA Domain.
- policyId: System.String
  - Identifier of the classification policy, when grouped by policy.
- analyzerId: System.String
  - Identifier of the analyzer, when grouped by analyzer.
- objectName: System.String
  - Display name of the workload, when grouped by object name.
- objectType: HierarchyObjectTypeEnum
  - Type of the workload this row belongs to.
- location: System.String
  - Human-readable location of the object.
- logicalPath: list of PathNodes
  - A sequential list of this object's logical ancestors.
