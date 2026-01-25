### AwsRoleCustomizationResponseType
Role customization details for the AWS account.

- crossAccountRoleName: System.String
  - Name of the cross-account role.
- crossAccountRolePath: System.String
  - Path of the cross-account role.
- masterRoleName: System.String
  - Name of the role for the Exocompute's master node.
- masterRolePath: System.String
  - Path of the role for the Exocompute's master node.
- workerRoleName: System.String
  - Name of the role for the Exocompute's worker node.
- workerRolePath: System.String
  - Path of the role for the Exocompute's worker node.
- instanceProfileName: System.String
  - Name of the instance profile for the Exocompute's worker node.
- instanceProfilePath: System.String
  - Path of the instance profile for the Exocompute's worker node.
- ec2RecoveryRolePath: System.String
  - Path that can be attached to a recovered EC2 instance.
- lambdaRoleName: System.String
  - Name of the role for Exocompute's lambda.
- lambdaRolePath: System.String
  - Path of the role for Exocompute's lambda.
- permissionBoundaryName: System.String
  - Name of the permission boundary for cross-account role.
- permissionBoundaryPath: System.String
  - Path of the permission boundary for cross-account role.
