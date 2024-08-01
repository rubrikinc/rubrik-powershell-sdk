### FinalizeAwsCloudAccountDeletionInput
Input to process and finalize deletion of AWS cloud account.

- cloudAccountId: System.String
  - Rubrik ID of account to be deleted.
- feature: CloudAccountFeature
  - Protection feature to be deleted for the cloud account.
- awsIamPairId: System.String
  - The internal ID of the IAM pair. This field is required only when the feature to be deleted is DATA_CENTER_ROLE_BASED_ARCHIVAL.
