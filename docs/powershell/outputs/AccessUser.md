### AccessUser
User with access to data discovered by classification.

- userSid: System.String
  - Stable identifier of the user (Windows SID or equivalent).
- username: System.String
  - Display name of the user.
- email: System.String
  - Email address of the user, if known.
- numActivities: System.Int64
  - Total number of activities recorded for this user in the request window.
- activityDelta: System.Int64
  - Activity count delta compared to the previous equivalent period.
- lastAccessTime: System.Int64
  - Last access time in milliseconds since the Unix epoch.
- subjectName: System.String
  - Display-friendly subject name (for example, "DOMAIN\\user").
