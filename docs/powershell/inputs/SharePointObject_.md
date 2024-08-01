### SharePointObject
Represents the SharePoint object (document library, list, site, or web part) to be restored.

- objectSharepointId: System.String
  - ID of the object in SharePoint Online.
- objectId: System.String
  - Rubrik cluster ID of the SharePoint object.
- objectName: System.String
  - Name or title of the object.
- objectType: SnappableType
  - Type of the object.
- snapshotId: System.String
  - UUID of the snapshot for recovery.
- snapshotNum: System.Int32
  - Sequence number of the snapshot.
- siteOwnerEmail: System.String
  - Site owner for restored site.
