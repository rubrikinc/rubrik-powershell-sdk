### GcpCloudAccountProjectDeleteStatus
Status of the Gcp Cloud Account delete operation.

- projectUuid: System.String
  - GCP project ID.
- success: System.Boolean
  - Specifies whether project deletion succeeded.
- error: System.String
  - Error during deletion, if any.
- featuresStatus: list of FeatureDeleteStatuss
  - Status of the individual features in delete operation.
