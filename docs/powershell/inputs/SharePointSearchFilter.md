### SharePointSearchFilter
Parameters for SharePoint site descendant search.

- searchKeywordFilter: SharePointSearchKeywordFilter
  - Filters by keywords appearing in the descendant object name.
- modifiedTime: TimeRangeFilter
  - Filters by modified time.
- createTime: TimeRangeFilter
  - Filters by on create time.
- searchObjectFilter: SharePointSearchObjectFilter
  - Filters by object type (site, library, list or all).
- lambdaFilters: LambdaPathFilters
  - Parameters for using Lambda filters in the query.
- descendantWorkloadId: System.String
  - The descendant workload ID to filter in the query.
