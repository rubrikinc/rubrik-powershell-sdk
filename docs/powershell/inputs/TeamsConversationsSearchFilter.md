### TeamsConversationsSearchFilter
Parameters for Teams conversations search.

- postedTime: TimeRangeFilter
  - Filters on the time of posts.
- channelNaturalId: System.String
  - Filters on the natural ID of the Teams channel that holds the posts.
- postedBy: System.String
  - Filters on the sender of the posts.
- snapshotId: System.String
  - Filters on the Rubrik Security Cloud ID of the snapshot to search.
- parentId: System.String
  - Filters on the ID of the parent post, used to retrieve the replies of a
single post.
- convId: System.String
  - Filters on the ID of the conversation that holds the posts.
- snapshotNum: System.Int32
  - The snapshot sequence number.
- includeArchived: System.Boolean
  - Specifies whether to include archived conversations.
- fetchAllPostSenders: System.String
  - Specifies whether to retrieve the full list of post-senders.
- skipPostsAttachments: System.Boolean
  - Specifies whether to skip attachments.
- lambdaFilters: LambdaPathFilters
  - Parameters for using Lambda filters in the query.
- itemId: System.String
  - Optional: filter to a single object by its M365 item ID.
Empty or unset = no filter.
