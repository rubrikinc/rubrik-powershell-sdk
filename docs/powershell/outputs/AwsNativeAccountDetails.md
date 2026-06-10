### AwsNativeAccountDetails
AWS native account details.

- id: System.String
  - Rubrik ID of the AWS account.
- name: System.String
  - Name of the AWS account.
- status: AwsAccountStatus
  - Status of the AWS account for the relevant feature.
- enabledFeatures: list of AwsNativeAccountEnabledFeatures
  - List of protection features enabled for the AWS account.
- serviceType: AwsCloudAccountServiceType
  - Service type indicating whether the account is onboarded for Backup-as-a-Service (BaaS) or non-BaaS use case.
