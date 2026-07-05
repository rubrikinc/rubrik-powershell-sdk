### CreateViolationRemediationInput
The input for creating remediation.

- resourceId: System.String
  - Required. The ID of the resource.
- remediationType: RemediationType
  - The type of remediation to perform.
- policyViolationId: System.String
  - The ID of the policy violation.
- targets: RemediationTargetsInput
  - Required. The remediation targets.
- location: RemediationLocation
  - Required. The location where the remediation has been done.
- resourceType: PolicyResourceType
  - Required. The type of the resource.
- ticketInfo: RemediationTicketInfoInput
  - The ticket information for the remediation.
- mipLabelInfo: MipLabelInfoInput
  - The MIP label information for the remediation.
- adIrInfo: AdIrInfoInput
  - The Active Directory information for the remediation.
- ticketDetails: TicketDetailsInput
  - Ticket details for remediation.
