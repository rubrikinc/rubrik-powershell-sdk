### SimulationResult
Specifies the result of simulating an action.

- action: System.String
  - Represents the specific AWS API action that was simulated
for permission validation.
- isAllowed: System.Boolean
  - Indicates whether the AWS IAM role has permission to perform the
specified action, based on the policy simulation results.
- isDeniedByScp: System.Boolean
  - Indicates whether the action was explicitly denied by AWS Service
Control Policies (SCPs).
- isDeniedByPermissionBoundaries: System.Boolean
  - Indicates whether the action was denied due to AWS IAM permission
boundaries.
- errorMessage: System.String
  - Specifies the detailed error description if the AWS IAM policy simulation
failed or encountered an unexpected error during validation.
