### UpdateTprConfigurationInput
Updating TPR configuration request.

- organizationId: System.String
  - Organization that is being updated.
- executionMaxTimeoutHours: System.Int32
  - Maximum timeout for on-demand execution of TPR requests, in hours.
- requestTimeoutHours: System.Int32
  - Number of hours before inactive TPR requests expire.
- reminderHours: System.Int32
  - Number of hours before TPR request expiration to send a reminder.
- staticQuorumApprovalsRequirement: System.Int32
  - Number of approvals needed for static quorum authorization policies.
