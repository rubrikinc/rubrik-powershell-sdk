### PrepareAwsCloudAccountDeletionReply
Prepares AWS cloud account for deletion and initiates deletion of the account.

- cloudFormationUrl: System.String
  - CloudFormation URL to delete the stack.
- featureRegionMap: a list of AwsCloudAccountFeatureVersions
  - List of feature versions.
- templateUrl: System.String
  - Template URL of the Cloudformation stack. The template URL is empty when the cloud account has no connected features and is to be deleted.
