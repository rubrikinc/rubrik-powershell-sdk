### SetWorkloadAlertSettingInput
Input required for setting workload alert.

- clusterId: System.String
  - Cluster ID of the workload.
- workloadFid: System.String
  - Fid of the workload.
- enabled: System.Boolean
  - Specifies whether alerts should be enabled or not enabled.
- products: list of DtaProducts
  - The Data Threat Analytics products whose alert setting is being changed.
An empty list defaults to Anomaly Detection.
