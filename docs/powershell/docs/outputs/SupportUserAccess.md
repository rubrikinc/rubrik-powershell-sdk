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
- accessProviderUser: User
  - User providing support user access.
- impersonatedUser: User
  - Impersonated user.
- accessStatus: SupportUserAccessStatus
  - Support user access status.
