### CcProvisionMetadataReply
Response for cloud cluster provision metadata.

- clusterUuid: System.String
  - UUID of the cluster.
- clusterName: System.String
  - Name of the cluster.
- jobType: System.String
  - Type of job.
- status: System.String
  - Current status of the job.
- statusMessage: System.String
  - Detailed status message.
- progress: System.Int32
  - Progress of the job in percent.
- internalTimestamp: System.Int64
  - Internal timestamp of the job.
- marshaledConfig: System.String
  - Job configuration in JSON format.
- clusterType: System.String
  - Type of cluster.
- vendor: System.String
  - Cloud vendor provider.
- clusterOpsCdmJobId: System.String
  - ID of the related CDM job.
- nodeToReplace: System.String
  - Node to be replaced (for node replacement jobs).
- tprRequestId: System.String
  - TPR request ID.
