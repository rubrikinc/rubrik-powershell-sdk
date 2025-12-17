### ElasticStorageConfig
Elastic storage configuration for CCES (Cloud Cluster with Elastic Storage).

- locationName: System.String
  - Object Store location (bucket name on S3 and container on Azure) name.
- locationId: System.String
  - Rubrik generated ID of the object store location.
- isImmutable: System.Boolean
  - Specifies whether the Cloud Cluster is using immutable cloud storage.
- isUsingManagedIdentity: System.Boolean
  - Specifies whether the Cloud Cluster is using managed identities to
authenticate to Azure cloud storage.
