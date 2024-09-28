### MutateRoleReqChangesTemplate
TPR requested changes template for editing TPR policies for a role.

- oldPolicies: list of TprPolicySummarys
  - Old policies on the role.
- newPolicies: list of TprPolicySummarys
  - New policies on the role.
- roleName: System.String
  - The role being mutated.
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
