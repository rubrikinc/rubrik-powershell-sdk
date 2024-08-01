### CreateTicketStatus
Status of the ticket creation request.

- SUCCESS - Ticket creation request is successful.
- FAILURE_INVALID_INPUT - Ticket request failed, because of invalid input.
- FAILURE_CONFLICTING_UUID - Ticket creation failed, because an existing ticket has the same UUID.
- FAILURE_INVALID_STATUS_TRANSITION - Ticket creation failed, because of an invalid status transition.
- FAILURE_NO_PLATFORM_CONFIGURED - Ticket creation failed, because of no configured ticketing platform.
