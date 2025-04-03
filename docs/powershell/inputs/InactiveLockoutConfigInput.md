### InactiveLockoutConfigInput
Specifies information about inactive lockout configuration.

- isInactiveLockoutEnabled: System.Boolean
  - Specifies whether the inactive lockout feature is enabled.
- inactivityDaysLimit: System.Int32
  - Specifies the number of inactive days after which a user will be locked.
- isWarningEmailEnabled: System.Boolean
  - Specifies whether warning emails are sent to user accounts pending lockout due to inactivity.
- numDaysBeforeWarningEmail: System.Int32
  - Specifies the number of days before lockout to send warning emails.
- isSelfServiceUnlockEnabled: System.Boolean
  - Specifies whether locked users can unlock themselves using a password reset.
