### TriggerCloudComputeConnectivityCheckInput
Input to trigger cloud compute connectivity check.

- id: System.String
  - Required. ID of the archival location.
- shouldCheckCloudConnectivityForCloudOn: System.Boolean
  - Required. v6.0-v7.0: Indicates if the cloud compute connectivity check should be performed for the CloudOn feature.

v8.0+: When should_check_cloud_connectivity_for_cloud_on is set to false, the Rubrik cluster verifies the cloud compute connectivity for Archive operations. When should_check_cloud_connectivity_for_cloud_on is set to true, The Rubrik cluster verifies the cloud compute connectivity for both Archive and CloudOn operations.
- shouldCheckCloudConnectivityForCloudOut: System.Boolean
  - Indicates if the cloud compute connectivity check should be performed for the CloudOut feature.
