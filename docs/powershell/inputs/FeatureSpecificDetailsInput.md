### FeatureSpecificDetailsInput
Optional additional information needed to retrieve the policy for a feature.

- ec2RecoveryRolePath: System.String
  - Rubrik can assign roles using this role path to a recovered EC2 instance.
- exocomputeMasterRoleArn: System.String
  - ARN of the role the customer created for the Exocompute master node. When set, the
iam:PassRole permission for it is scoped to this exact role instead of the role path
wildcard. Applies only when Exocompute has the RSC_MANAGED_CLUSTER permissions group.
- exocomputeWorkerRoleArn: System.String
  - ARN of the role the customer created for the Exocompute worker node. When set, the
iam:PassRole permission for it is scoped to this exact role instead of the role path
wildcard. Applies only when Exocompute has the RSC_MANAGED_CLUSTER permissions group.
- exocomputeLambdaRoleArn: System.String
  - ARN of the role the customer created for the Exocompute lambda. When set, the
iam:PassRole permission for it is scoped to this exact role instead of the role path
wildcard. Applies only when Exocompute has the RSC_MANAGED_CLUSTER permissions group.
