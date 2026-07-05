### GcpCloudNativeTarget
GCP cloud native archival specific fields for GCP Target Template.
GraphQL view that uses CloudAccountV2 and TagObject instead of
CloudAccount and map<string, string>.

- cloudAccount: CloudAccount
  - Cloud account details of the target.
- labels: list of TagObjects
  - Labels for the GCP bucket.
- cmkInfo: list of GcpCmks
  - List of configured customer managed keys per region.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Template type of the storage settings. Must be either SOURCE_REGION or SPECIFIC_REGION.
