### CustomTprPolicy
Used in bulk query for TPR policy listing.

- policyId: System.String
  - TPR policy ID.
- policyName: System.String
  - Name of the TPR policy.
- description: System.String
  - Description of the TPR policy.
- numberOfObjectTypes: System.Int32
  - Number of object types in the TPR policy.
- numberOfProtectableObjects: System.Int32
  - Number of workloads in the TPR policy.
- orgId: System.String
  - Organization the TPR policy is in.
- actions: list of TprRules
  - Actions specified in the TPR policy.
- quorumRequirement: System.Int32
  - Quorum authorization requirement for the TPR policy.
- orgName: System.String
  - Organization name the TPR policy is in.
