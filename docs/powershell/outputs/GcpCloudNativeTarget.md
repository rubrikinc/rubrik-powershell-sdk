### GcpCloudNativeTarget
GCP native archival specific fields for GCP Target Template.

- labels: list of TagObjects
  - Labels for the GCP bucket.
- cmkInfo: list of GcpCmks
  - List of configured customer managed keys per region.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Template type of the storage settings. Must be either SOURCE_REGION or SPECIFIC_REGION.
- cloudAccount: CloudAccount
  - Cloud account details of the target.
