### TprRequestSummary
Used in bulk query for TPR requests.

- requester: UserSummary
  - User making the TPR request.
- orgId: System.String
  - ID of the organization.
- orgName: System.String
  - Name of the organization.
- status: TprReqStatus
  - Status of the request.
- updatedAt: DateTime
  - Time the request was last updated.
- triggeredTprRule: TprRule
  - Highest priority rule triggered by the request.
- requestId: System.String
  - TPR Request ID.
- operations: AuthorizedOps
  - Authorized operations.
