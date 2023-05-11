### ClusterMetadata
Metadata for a single cluster job.

- clusterName: System.String
  - Name of cluster.
- clusterType: CcpClusterType
  - Type of cluster.
- clusterUuid: System.String
  - Cluster uuid.
- jobStartTime: System.Int64
  - Start time for the job.
- jobStatus: CcpJobStatus
  - Current job status.
- jobType: CcpJobType
  - Type of running job.
- marshaledConfig: System.String
  - Job configuration json.
- progress: System.Int32
  - Progress of job in percent.
- statusMessage: System.String
  - Job status message.
- vendor: CcpVendorType
  - Cloud vendor provider.
