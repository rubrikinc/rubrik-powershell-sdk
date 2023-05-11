### AwsCloudAccountCreateResponse
Initiate aws cloud accounts.

- awsRegions: a list of AwsCloudAccountRegions
  - List of AWS regions for the cloud account.
- cloudFormationUrl: System.String
  - AWS CloudFormation URL.
- externalId: System.String
  - External ID for the cloud account.
- featureVersions: a list of AwsCloudAccountFeatureVersions
  - List of feature versions.
- roleArn: System.String
  - Role ARN for the feature (if valid).
- stackName: System.String
  - Stack name of template to run, only for single account addition.
- stackSetName: System.String
  - StackSet name of template to run, only for bulk account addition.
- templateUrl: System.String
  - AWS CloudFormation template URL.
