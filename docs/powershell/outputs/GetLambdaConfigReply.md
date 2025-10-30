### GetLambdaConfigReply
Lambda configuration details of the Rubrik cluster.

- accountId: System.String
  - The account id associated with the request.
- clusterId: System.String
  - The cluster UUID.
- enableAutomaticFmdUpload: System.Boolean
  - Whether automatic fmd upload is enabled for the cluster.
- enableFmdUploadForAllResources: System.Boolean
  - Whether fmd upload is enabled for all resources.
- defaultDiffFmdUploadPrefix: System.String
  - The default diff fmd upload prefix.
- maxSnapshotsToUploadAutomatically: System.Int32
  - The maximum number of snapshots to upload automatically.
- isThreatMonitoringEnabled: System.Boolean
  - Enable or disable threat monitoring.
- enableThreatMonitoringFullScan: System.Boolean
  - Enable or disable full scans for threat monitoring.
- orionYaraRemoteProcessingEnabled: System.Boolean
  - Enable or disable yara remote processing (sandboxing).
