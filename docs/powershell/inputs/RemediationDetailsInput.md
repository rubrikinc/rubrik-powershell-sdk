### RemediationDetailsInput
Details for the remediation to be done.

- isJitElevated: System.Boolean
  - Set by the UI for elevated JIT onboardings once permission elevation
completed before creating the revert remediation. Ignored for non-revert
remediation types and for AUTOMATION origin.
- ticketInfo: RemediationTicketInfoInput
  - Ticket information for remediation.
- mipLabelInfo: MipLabelInfoInput
  - MIP label information.
- adIrInfo: AdIrInfoInput
  - AD IR information.
- ticketDetails: TicketDetailsInput
  - Ticket details.
