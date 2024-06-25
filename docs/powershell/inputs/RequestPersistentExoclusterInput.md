### RequestPersistentExoclusterInput
Input to request persistent Exocompute cluster for a region configuration in a cloud account.

- cloudVendor: CloudVendor
  - Cloud provider type.
- exocomputeConfigId: System.String
  - ID of the Exocompute configuration.
- durationInDays: System.Int32
  - Duration for which cluster is to be persisted. Note that the cluster will not be torn down immediately, and will only be released when it's not in use by any other job.
- azureSpecificClusterParams: AzureClusterRequestParams
  - Customized parameters for launching Azure clusters.
- awsSpecificClusterParams: AwsClusterRequestParams
  - Customized parameters for launching AWS clusters.
