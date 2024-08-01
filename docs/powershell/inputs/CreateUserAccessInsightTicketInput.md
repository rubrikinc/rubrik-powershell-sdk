### CreateUserAccessInsightTicketInput
Input for creating a ticket related to an insight.

- insightUuid: System.String
  - Insight UUID of the parent insight.
- platformType: TicketingPlatform
  - Ticketing platform to create the ticket on.
- ticketInfo: TicketInfoInput
  - Information for the ticket to be created.
- timelineDate: System.Int64
  - Date, in Unix epoch, for the insight.
