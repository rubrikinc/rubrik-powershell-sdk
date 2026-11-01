### GcpCloudAccountDeleteProjectsV2FeatureInput
Input to delete a feature for a list of GCP cloud accounts.

- feature: CloudAccountFeature
  - Feature to be deleted.
- cloudAccountIds: list of System.Strings
  - List of cloud account IDs.
- deleteSnapshots: System.Boolean
  - Specifies whether to also delete the corresponding snapshots from GCP.
Applies only to protection features. Snapshots are kept when this is
unset or false. Can't be true when skipResourceDeletion is true.
Deprecated, will be replaced by skipResourceDeletion.
- skipResourceDeletion: System.Boolean
  - When true, removes the cloud account from Rubrik Security Cloud
without tearing down most resources in GCP. Some Rubrik-created GCP
resources may remain and require manual cleanup.
