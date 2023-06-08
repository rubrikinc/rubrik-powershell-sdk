### ClusterMetadata
Metadata for a single cluster job.

- clusterUuid: System.String
  - Cluster uuid.
- jobStartTime: System.Int64
  - Start time for the job.
- clusterName: System.String
  - Name of cluster.
- clusterType: CcpClusterType
  - Type of cluster.
- vendor: CcpVendorType
  - Cloud vendor provider.
- jobStatus: CcpJobStatus
  - Current job status.
- statusMessage: System.String
  - Job status message.
- progress: System.Int32
  - Progress of job in percent.
- jobType: CcpJobType
  - Type of running job.
- marshaledConfig: System.String
  - Job configuration json.
