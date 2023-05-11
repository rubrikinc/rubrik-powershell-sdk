### AmiTypeForAwsNativeArchivedSnapshotExportReply
Amazon Machine Image (AMI) type for exporting an archived EC2 Instance snapshot.

- amiId: System.String
  - If amiType is pre-existing, this field will contain the ID of the AMI.
- amiType: AmiType
  - Type of the AMI to be used for export of EC2 instance archived snapshot. This can be an existing AMI, or a runtime-generated AMI or a user-specified AMI.
- awsAccountRubrikId: System.String
  - Rubrik Id of the aws account which contains the pre-existing AMI.
- regionNativeId: AwsNativeRegion
  - Region where the pre-existing AMI exists.
