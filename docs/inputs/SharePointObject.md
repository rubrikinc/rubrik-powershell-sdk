### SharePointObject
Represents the SharePoint object (document library, list, site, or web part) to be restored.

- objectName: System.String
  - Name or title of the object.
- objectSharepointId: System.String
  - ID of the object in SharePoint Online.
- objectType: SnappableType
  - Type of the object.
- snapshotId: System.String
  - UUID of the snapshot for recovery.
- snapshotNum: System.Int32
  - Sequence number of the snapshot.
