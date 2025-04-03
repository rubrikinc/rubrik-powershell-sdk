### OnedriveSearchFilter
Parameters for OneDrive file or folder search.

- searchKeywordFilter: OnedriveSearchKeywordFilter
- modifiedTime: TimeRangeFilter
- createTime: TimeRangeFilter
- searchObjectFilter: OnedriveSearchObjectFilter
- channelId: System.String
- channelFolderName: System.String
- channelMembershipType: ChannelMembershipType
- excludeItemsUnderRoot: System.Boolean
- channelNameKeyword: System.String
- useExactVersionMatch: System.Boolean
  - Determines whether to use exact version match query.
- lambdaFilters: LambdaPathFilters
  - Parameters to use lambda filters in query.
- objectId: System.String
  - Parameters to use object ID in query.
- filePath: System.String
  - Parameters to use file path in query.
- parentWorkloadId: System.String
  - Parameters to specify parent ID, which is used to search using the full path from the parent site.
