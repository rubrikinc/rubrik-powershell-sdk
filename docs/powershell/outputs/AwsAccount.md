### AwsAccount
AWS Account specific info.

- accessKey: System.String
  - Access key for IAM user, which is required while adding new AWS cloud account.
- awsNativeId: System.String
  - Native ID of the AWS account.
- stsEndpoint: System.String
  - STS VPC endpoint of the AWS account.
- stsRegion: AwsRegion
  - Region for STS service.
- cloudAccountId: System.String
  - The ID of this Cloud Account.
- name: System.String
  - The name of this Cloud Account.
- description: System.String
  - The description of this Cloud Account.
- cloudProvider: CloudAccountType
  - The type of this Cloud Provider.
- connectionStatus: ConnectionStatusType
  - The connection status of this Cloud Account.
