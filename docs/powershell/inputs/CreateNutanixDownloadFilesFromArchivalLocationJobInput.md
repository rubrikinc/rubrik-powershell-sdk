### CreateNutanixDownloadFilesFromArchivalLocationJobInput


- config: NutanixDownloadFilesJobConfigInput
  - Required. v8.0: Configuration information for a job to download files and folders from a Nutanix VM snapshot.
v8.1+: Configuration information for a job to download files and folders from a Nutanix virtual machine snapshot.
- snapshotId: System.String
  - Required. v8.0: ID of Nutanix VM snapshot.
v8.1+: ID of Nutanix virtual machine snapshot.
- locationId: System.String
  - Required. ID of the archival location.
