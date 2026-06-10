### TeamsConversationsSearchFilter
Parameters for Teams conversations search.

- postedTime: TimeRangeFilter
  - Filters on the time of posts.
- channelNaturalId: System.String
- postedBy: System.String
- snapshotId: System.String
- parentId: System.String
- convId: System.String
- snapshotNum: System.Int32
  - The snapshot sequence number.
- includeArchived: System.Boolean
  - Specifies whether to include archived conversations.
- fetchAllPostSenders: System.String
  - Specifies whether to send post senders.
- skipPostsAttachments: System.Boolean
  - Specifies whether to skip attachments.
- lambdaFilters: LambdaPathFilters
  - Parameters for using Lambda filters in the query.
