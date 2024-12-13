### JobInfoRequest
Request message for polling the status of a job.

- requestId: System.String
  - ID of the request.
- clusterUuid: System.String
  - ID of the cluster.
- type: JobType
  - Type of job to be polled.
- additionalInfo: JobInfoRequestDetails
  - Additional information that may be required for certain job types.
