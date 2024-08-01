### PingMultiClusterPcReply
Response for the ping Nutanix Prism Central operation.

- isDrEnabled: System.Boolean
  - Specifies whether Disaster Recovery (DR) is configured on Prism Central.
- hostname: System.String
  - Hostname for the Nutanix Prism Central that we
        use for all the cluster connections.
- nutanixClusters: list of NutanixClustersListElementWithConnectionStatuss
  - The list of Nutanix Cluster connection status with CDM and its natural uuid and name.
