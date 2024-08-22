### UpdateCustomIntelFeedInput
Input request for update custom intel feed.

- user: System.String
  - User.
- name: ProviderName
  - Provider name - optional.
- providerId: System.String
  - Provider ID.
- description: ProviderDescription
  - Provider description - optional.
- entriesToAdd: list of CustomEntriess
  - Entries to add - optional.
- entriesToRemove: list of System.Strings
  - Optional - The string to be removed, corresponding to the hex representation of either:
   1) A hash (MD5/SHA1/SHA256)
   2) MD5 of a yara rule
