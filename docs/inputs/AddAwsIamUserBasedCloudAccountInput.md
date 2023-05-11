### AddAwsIamUserBasedCloudAccountInput
Input to add IAM user-based AWS cloud account for native protection.

- accessKey: System.String
  - Access key for IAM user with native protection policy on AWS cloud account. Access key is required only while adding new AWS cloud account.
- awsRegions: a list of AwsCloudAccountRegions
  - List of AWS regions for the cloud account.
- cloudAccountName: System.String
  - Name of cloud account.
- cloudType: AwsCloudType
  - Cloud type (Standard/China/Gov) for the cloud account.
- features: a list of CloudAccountFeatures
  - List of features to be enabled for cloud native protection.
- nativeId: System.String
  - Native ID of cloud account.
- roleArn: System.String
  - AWS Role ARN with native protection policy on AWS cloud account. Role name must start with 'rubrik-polaris-'. Role ARN is required only while adding new AWS cloud account.
- secretKey: System.String
  - Secret key for IAM user with native protection policy on AWS cloud account. Secret key is required only while adding new AWS cloud account.
