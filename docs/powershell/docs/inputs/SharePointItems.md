### SharePointItems
Represents the SharePoint items in a site collection to be restored.

- sharepointId: System.String
  - ID of the object in SharePoint Online.
- snappableType: SnappableType
  - Type of the parent object.
- listItems: list of SharePointListItems
  - The list items to restore when the parent object is a list.
- folderItems: list of FolderInfos
  - The folder items to restore.
- fileItems: list of FileInfos
  - The files to restore when the parent object is a document library.
- arePageLibraryItems: System.Boolean
  - Specifies whether these SharePoint items are Page Library items or not.
