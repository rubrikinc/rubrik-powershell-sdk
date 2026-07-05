### TicketContentsInput
Parameters needed to create a ticket.

- title: System.String
  - Title of the ticket.
- description: System.String
  - Description of the ticket.
- comment: System.String
  - Additional comment for the ticket.
- projectKey: System.String
  - Project key for ticket creation.
- ticketTypeId: System.String
  - Ticket type ID for ticket creation.
- requiredFields: list of TicketFieldEntryInputs
  - Dynamic required field values for platform-specific ticket fields.
