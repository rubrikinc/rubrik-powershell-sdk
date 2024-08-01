### AmiTypeForAwsNativeArchivedSnapshotExportInput
Input to retrieve  Amazon Machine Image (AMI) type for AWS Archived snapshot export.

- snapshotId: System.String
  - ID of snapshot to export. Snapshot should have an archived copy present.
- destinationRegionId: AwsNativeRegion
  - Target region for export.
- destinationAwsAccountRubrikId: System.String
  - Rubrik ID of the target AWS account for export.
