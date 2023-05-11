### SharePointItems
Represents the SharePoint items in a site collection to be restored.

- arePageLibraryItems: System.Boolean
  - Specifies whether these SharePoint items are Page Library items or not.
- fileItems: a list of FileInfos
  - The files to restore when the parent object is a document library.
- folderItems: a list of FolderInfos
  - The folder items to restore.
- listItems: a list of SharePointListItems
  - The list items to restore when the parent object is a list.
- sharepointId: System.String
  - ID of the object in SharePoint Online.
- snappableType: SnappableType
  - Type of the parent object.
