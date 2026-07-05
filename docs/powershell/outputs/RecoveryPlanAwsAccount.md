### RecoveryPlanAwsAccount
Identifying details for an AWS account used as a recovery plan location.

- id: System.String
  - Identifier of the AWS account.
- name: System.String
  - Name of the AWS account.
- status: AwsAccountStatus
  - Protection status of the AWS account.
- cloudType: AwsCloudType
  - Cloud partition the AWS account belongs to.
- regionSpecs: list of AwsNativeRegionSpecs
  - Region specifications configured for the AWS account.
