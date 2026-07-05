### OktaTenantSpecificSnapshot
Specific information for an Okta tenant snapshot. Carries per-snapshot workflow protection state.

- isWorkflowSetUp: System.Boolean
  - Whether workflow protection was set up on the tenant when this snapshot was taken.
- workflowProtectionFailureReason: System.String
  - Reason workflow protection failed for this snapshot, if any.
- snapshotId: System.String
  - ID of the snapshot.
