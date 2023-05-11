### O365SnapshotItemInfo
Browse or search delta response returns Microsoft Office 365 file or folder data.

- folderIdsTillRoot: a list of System.Strings
  - Returns a list of folder IDs that contains the absolute path of the given item, starting with root and ending with the item. The first element in the list is the root, and the last is the item itself.
- id: System.String
  - The ID of the Microsoft Office 365 OneDrive object.
- o365ReplyFields: O365ReplyFields
  - Returns fields related to different Microsoft Office 365 SharePointDrive/OneDrive types.
- parentFolderId: System.String
  - The parent folder ID of the object (ROOT indicates root folder).
- snapshotId: System.String
  - The ID of the snapshot.
- snapshotNum: System.Int32
  - The sequence number of the snapshot.
