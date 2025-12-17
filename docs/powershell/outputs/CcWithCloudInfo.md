### CcWithCloudInfo
Detailed cloud information for a Cloud Cluster.

- uuid: System.String
  - Cloud Cluster UUID.
- name: System.String
  - Cloud Cluster name.
- region: System.String
  - User-friendly name for the cloud region.
- regionId: System.String
  - ID for the cloud region.
- networkName: System.String
  - Native name of the network where the Cloud Cluster exists.
- nativeCloudAccountName: System.String
  - Native name of the cloud account where the Cloud Cluster exists.
- cloudAccountId: System.String
  - Rubrik-generated cloud account UUID.
- vendor: CcpVendorType
  - Cloud provider.
- nativeCloudAccountId: System.String
  - Native (AWS/Azure) ID of cloud account.
- cloudAccount: System.String
  - Native name of the cloud account where the Cloud Cluster exists.
- storageConfig: ElasticStorageConfig
  - Elastic Storage configuration.
