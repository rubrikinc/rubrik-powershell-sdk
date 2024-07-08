### UpdateCustomIntelFeedInput
Input request for update custom intel feed.

- feedId: System.String
  - Feed ID.
- entriesToRemove: list of System.Strings
  - Optional - The string corresponds to a hash or yara rule that needs to be removed.
- name: FeedName
  - Feed Name - optional.
- description: FeedDescription
  - Feed Description - optional.
- entriesToAdd: list of CustomEntriess
  - Entries to add - optional.
