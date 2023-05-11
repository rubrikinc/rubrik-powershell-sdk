### GenerateSupportBundleInput
Input for generating support bundle.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- definitions: GenerateSupportBundleRequestInput
  - Either event id or request id list of the request to be collected, if both are provided, request id list would be ignored.
