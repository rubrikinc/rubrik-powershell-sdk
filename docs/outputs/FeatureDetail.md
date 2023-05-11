### FeatureDetail
Feature specific details for a cloud account.

- accessKey: System.String
  - IAM user access key for feature. This field has a non-empty value only for accounts with an IAM user credential provider.
- authServerDetail: AwsAuthServerDetail
  - Details for authentication server-based cloud accounts. This field is only applicable to the accounts in AWS DCA and LCK regions.
- awsRegions: a list of AwsCloudAccountRegions
  - AWS regions. The list will be non-empty for cloud accounts on AWS GovCloud and commercial clouds.
- feature: CloudAccountFeature
  - Feature enum.
- roleArn: System.String
  - Role ARN for feature. This field has a non-empty value only for CFT-based accounts.
- stackArn: System.String
  - Stack ARN for feature. This field has a non-empty value only for CFT-based accounts.
- status: CloudAccountStatus
  - Feature status for a cloud account.
- userArn: System.String
  - User ARN for feature. This field has a non-empty value only for accounts with an IAM user credential provider.
