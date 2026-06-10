### SharePointSearchFilter
Parameters for SharePoint site descendant search.

- searchKeywordFilter: SharePointSearchKeywordFilter
  - Filters by keywords appearing in the descendant object name.
- modifiedTime: TimeRangeFilter
  - Filters on modified time.
- createTime: TimeRangeFilter
  - Filters on create time.
- searchObjectFilter: SharePointSearchObjectFilter
  - Filters on object type.
- lambdaFilters: LambdaPathFilters
  - Used for Lambda search/browse, diff/full FMD paths for Onedrive.
- descendantWorkloadId: System.String
  - The descendant workload identifier to filter in the query.
