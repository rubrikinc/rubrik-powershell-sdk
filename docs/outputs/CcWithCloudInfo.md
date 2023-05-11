### CcWithCloudInfo
Detailed cloud information for a Cloud Cluster.

- cloudAccount: System.String
  - Native name of the cloud account where the Cloud Cluster exists.
- cloudAccountId: System.String
  - Rubrik-generated cloud account UUID.
- name: System.String
  - Cloud Cluster name.
- nativeCloudAccountId: System.String
  - Native (AWS/Azure) ID of cloud account.
- nativeCloudAccountName: System.String
  - Native name of the cloud account where the Cloud Cluster exists.
- networkName: System.String
  - Native name of the network where the Cloud Cluster exists.
- region: System.String
  - User-friendly name for the cloud region.
- regionId: System.String
  - ID for the cloud region.
- storageConfig: ElasticStorageConfig
  - Elastic Storage configuration.
- uuid: System.String
  - Cloud Cluster UUID.
- vendor: CcpVendorType
  - Cloud provider.
