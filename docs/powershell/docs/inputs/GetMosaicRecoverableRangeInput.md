### GetMosaicRecoverableRangeInput
Input for getting NoSQL protection recoverable range of snapshots.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- recoveryRangeRequestData: MosaicRecoverableRangeRequestInput
  - Required. Request Object with details of Tables whose recovery range is required.
