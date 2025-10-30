### GcpCloudAccountDeleteProjectsV2FeatureInput
Input to delete a feature for a list of GCP cloud accounts.

- feature: CloudAccountFeature
  - Feature to be deleted.
- deleteSnapshots: System.Boolean
  - For protection features whether to delete
the corresponding snapshots from GCP as well.
- cloudAccountIds: list of System.Strings
  - List of cloud account IDs.
