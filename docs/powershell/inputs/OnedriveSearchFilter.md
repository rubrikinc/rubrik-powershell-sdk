### OnedriveSearchFilter
Parameters for OneDrive file or folder search.

- searchKeywordFilter: OnedriveSearchKeywordFilter
- modifiedTime: TimeRangeFilter
  - Filters on modified time.
- createTime: TimeRangeFilter
  - Filters on create time.
- searchObjectFilter: OnedriveSearchObjectFilter
  - Filters on object type.
- channelId: System.String
  - Used for Teams search over SharePoint Document Library.
- channelFolderName: System.String
- channelMembershipType: ChannelMembershipType
  - 
- excludeItemsUnderRoot: System.Boolean
  - This filter excludes any items under root from the
search results. This is used to hide channel items from
Teams Files search.
- channelNameKeyword: System.String
- useExactVersionMatch: System.Boolean
  - Determines whether to use exact version match query.
- lambdaFilters: LambdaPathFilters
  - Parameters to use Lambda filters in query.
- objectId: System.String
  - Parameters to use object ID in query.
- filePath: System.String
  - Filters on file path.
- parentWorkloadId: System.String
  - Specifies the parent workload identifier for searching using the full path from the parent site.
