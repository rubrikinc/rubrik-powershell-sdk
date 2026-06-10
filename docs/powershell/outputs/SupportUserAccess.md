### SupportUserAccess
Support user access object details.

- id: System.Int32
  - Support user access ID.
- startTime: DateTime
  - Support user access start time.
- durationInHours: System.Int32
  - Support user access duration, in hours.
- endTime: DateTime
  - Support user access end time.
- ticketNumber: System.String
  - Ticket number associated to the support user access request.
- actualEndTime: DateTime
  - Actual time when the support access session ended. Null while open.
- accessProviderUser: User
  - User providing support user access.
- impersonatedUser: User
  - Impersonated user.
- accessStatus: SupportUserAccessStatus
  - Support user access status.
