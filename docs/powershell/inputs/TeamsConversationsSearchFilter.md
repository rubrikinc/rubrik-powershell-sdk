### TeamsConversationsSearchFilter
Parameters for teams conversations search.

- postedTime: TimeRangeFilter
- channelNaturalId: System.String
- postedBy: System.String
- snapshotId: System.String
- parentId: System.String
- convId: System.String
- snapshotNum: System.Int32
- includeArchived: System.Boolean
- fetchAllPostSenders: System.String
  - Describes whether to send post senders(shouldn't be called by UI).
- skipPostsAttachments: System.Boolean
  - Describes whether to skip attachments(shouldn't be called by UI).
- lambdaFilters: LambdaPathFilters
  - Parameters for using Lambda filters in the query.
