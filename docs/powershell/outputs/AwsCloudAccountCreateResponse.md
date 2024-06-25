### AwsCloudAccountCreateResponse
Initiate aws cloud accounts.

- awsRegions: list of AwsCloudAccountRegions
  - List of AWS regions for the cloud account.
- templateUrl: System.String
  - AWS CloudFormation template URL.
- stackName: System.String
  - Stack name of template to run, only for single account addition.
- stackSetName: System.String
  - StackSet name of template to run, only for bulk account addition.
- cloudFormationUrl: System.String
  - AWS CloudFormation URL.
- externalId: System.String
  - External ID for the cloud account.
- featureVersions: list of AwsCloudAccountFeatureVersions
  - List of feature versions.
- roleArn: System.String
  - Role ARN for the feature (if valid).
- awsIamPairId: System.String
  - ID of IAM pair, only for data center role-based archival.
