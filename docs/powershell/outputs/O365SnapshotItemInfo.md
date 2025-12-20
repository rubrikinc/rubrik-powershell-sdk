### O365SnapshotItemInfo
Browse or search delta response returns Microsoft Office 365 file or folder data.

- id: System.String
  - The ID of the Microsoft Office 365 OneDrive object.
- parentFolderId: System.String
  - The parent folder ID of the object (ROOT indicates root folder).
- snapshotNum: System.Int32
  - The sequence number of the snapshot.
- snapshotId: System.String
  - The ID of the snapshot.
- folderIdsTillRoot: list of System.Strings
  - Returns a list of folder IDs that contains the absolute path of the given item, starting with root and ending with the item. The first element in the list is the root, and the last is the item itself.
- metadata: MetadataFields
  - Returns fields related to metadata for different Microsoft Office 365 SharePoint Drive and OneDrive types.
- o365ReplyFields: O365ReplyFields
  - Returns fields related to different Microsoft Office 365 SharePointDrive/OneDrive types.
