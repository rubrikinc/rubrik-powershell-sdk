### CloudDirectCopyScheduleList
ListCopyScheduleReply is the response for ListCloudDirectCopySchedules.

- schedules: list of CloudDirectCopyScheduleItems
  - Schedules are the non-archived copy schedules visible to the caller.
- nextPageCursor: System.String
  - Next page cursor is the continuation token for the following page, or
empty when this is the last page.
