### CloudNativeRegion
Region where cloud native object exists.

- awsRegion: AwsNativeRegion
  - Region where AWS native object exists. This field will be null if the object is not an AWS object.
- azureRegion: AzureNativeRegion
  - Region where Azure native object exists. This field will be null if the object is not an Azure object.
- gcpRegion: GcpNativeRegion
  - Region where GCP native object exists. The zones field is empty for now and can be populated in future as and when needed. This field will be null if the object is not a GCP object.
