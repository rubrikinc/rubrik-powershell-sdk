### ThreatHuntCloudDirectCluster
Cloud Direct NAS Cluster for Threat Monitoring.

- id: System.String
  - The cluster UUID.
- name: System.String
  - The cluster name.
- connectionStatus: System.String
  - The cluster connection status.
- productType: ClusterProductEnum
  - The cluster product type.
- version: System.String
  - The software version of the cluster.
- status: ClusterStatus
  - The cluster status.
- lambdaConfig: GetLambdaConfigReply
  - Lambda configuration for threat monitoring.
