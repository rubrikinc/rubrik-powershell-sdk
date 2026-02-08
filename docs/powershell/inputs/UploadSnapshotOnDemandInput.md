### UploadSnapshotOnDemandInput
UploadSnapshotOnDemandReq is the request object for triggering an on-demand
upload of a snapshot to a new archival location.

- snapshotId: System.String
  - The ID of the snapshot to be uploaded.
- slaId: System.String
  - The ID of the SLA Domain that contains the archival location
to which the snapshot should be uploaded.
- priority: UploadSnapshotOnDemandPriority
  - Priority of the upload request.
