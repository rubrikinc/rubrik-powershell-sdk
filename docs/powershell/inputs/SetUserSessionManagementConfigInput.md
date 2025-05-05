### SetUserSessionManagementConfigInput
Input information on the user's session management configuration.

- isConcurrentSessionLimitationEnabled: System.Boolean
  - Specifies whether the user has enforced a limit on the maximum number of sessions. The value is true if the user has enforced a limit on the maximum number of sessions and false otherwise.
- inactivityTimeoutInSeconds: System.Int64
  - Integer value specifying the number of seconds before the session logs out if the user is inactive.
- isInactivityTimeoutEnabled: System.Boolean
  - Specifies whether the user has enforced a session timeout when the maximum time limit on inactivity is reached.
- maxConcurrentSessions: System.Int32
  - Integer value indicating the maximum number of sessions set by the user.
- sessionTimeoutInSeconds: System.Int64
  - Indicates the number of seconds before the session logs out.
- clientSessionTimeoutInSeconds: System.Int64
  - Indicates the number of seconds before the service account session logs out.
