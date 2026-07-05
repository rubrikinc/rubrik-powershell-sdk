### GetUserDetailReply
Reply for GetUserDetail. Contains summary attributes for the requested user.

- name: System.String
  - Display name of the user.
- risk: RiskLevelType
  - Risk level computed for the user over the requested window.
- location: System.String
  - Display-friendly location string for the user.
- numFilesAccessible: System.Int32
  - Number of files this user can access.
