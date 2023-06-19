### SharePointFullRestoreConfig
Represents the objects or items to be restored from a site collection. Either the SharePoint object or SharePoint items should be populated, but not both.

- spObjectToRestore: SharePointObject
  - The object (list, document library, web part, or site) to restore.
- spItemsToRestore: SharePointItems
  - The items to restore, if browsing within a document library, list, or web part.
- targetObjectUuid: System.String
  - The Polaris ID of the target when restoring to a new location.
- targetObjectType: SnappableType
  - Type of the target.
- shouldCreateNewObject: System.Boolean
  - Create a new object under the target if true.
- newObjectType: SnappableType
  - Type of object to create under the target.
- newObjectName: System.String
  - The name for the new object.
