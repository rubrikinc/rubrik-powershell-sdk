### DeleteSnapshotsTprReqChangesTemplate
TPR requested changes template for deleting snapshots.

- snapshotLocations: list of SnapshotLocationSummarys
  - Snapshot locations that are part of the request.
- snapshotInfos: list of TprSnapshotInfos
  - Per-snapshot information including type and applicable locations.
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
