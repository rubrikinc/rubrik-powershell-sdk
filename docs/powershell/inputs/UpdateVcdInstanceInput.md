### UpdateVcdInstanceInput
vCD instance to update in a cluster.

- clusterUuid: System.String
  - Required. UUID of the Rubrik cluster the request goes to.
- id: System.String
  - Required. ID of the vCD instance to be updated.
- definition: VcdClusterPatchInput
  - Required. JSON object for a vCD instance.
