### GcpTargetTemplate
Specific info for GCP Target Template.

- bucketPrefix: System.String
  - GCP target bucket prefix.
- region: GcpRegion
  - GCP target region.
- storageClass: GcpStorageClass
  - GCP target storage class.
- cmkInfo: list of GcpCmks
  - List of Customer managed key ring and key information for a region.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Cloud native template type.
- labels: list of TagObjects
  - GCP target bucket labels.
- cloudAccount: CloudAccount
  - Cloud Account information of the GCP target.
- targetType: TargetType
  - The type of this Target.
