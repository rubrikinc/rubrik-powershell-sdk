### CloudNativeStorageClassTier
Cloud-provider native storage class for a snapshot's archival location. At most one cloud-specific field is populated; the rest are null.

- awsStorageClass: AwsStorageClass
  - AWS S3 storage class (e.g. STANDARD, GLACIER_INSTANT_RETRIEVAL). Null unless the archival location is an AWS-native S3 location.
- azureStorageTier: AzureStorageTier
  - Azure access tier. Null unless the archival location is an Azure location.
- gcpStorageClass: GcpStorageClass
  - GCP storage class. Null unless the archival location is a GCP location.
