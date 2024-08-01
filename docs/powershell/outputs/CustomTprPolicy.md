### CustomTprPolicy
Used in bulk query for TPR policy listing.

- policyName: System.String
  - Name of the TPR policy.
- description: System.String
  - Description of the TPR policy.
- numberOfObjectTypes: System.Int32
  - Number of object types in the TPR policy.
- numberOfProtectableObjects: System.Int32
  - Number of workloads in the TPR policy.
- actions: list of TprRules
  - Actions specified in the TPR policy.
- policyId: System.String
  - TPR policy ID.
- orgId: System.String
  - Organization the TPR policy is in.
