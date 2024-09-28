### TriggeredTprPolicy
Policy triggered by a TPR request.

- name: System.String
  - Name of the policy.
- archived: System.Boolean
  - Specifies whether the policy is archived.
- quorumRequirement: System.Int32
  - Number of approvers required for the policy.
- approverIds: list of System.Strings
  - IDs of the users who have approved the request for the triggered policy.
- status: TprPolicyStatus
  - Status of the policy.
- id: System.String
  - ID of the policy.
