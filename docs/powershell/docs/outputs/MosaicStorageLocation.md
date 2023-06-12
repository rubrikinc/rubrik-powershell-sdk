### MosaicStorageLocation
Response object for list store on mosaic.

- fid: System.String
  - Fid of Mosaic Storage Locations.
- id: System.String
  - Mosaic ID of Storage Location.
- clusterUuid: System.String
  - UUID of Mosaic Cluster.
- storageLocationName: System.String
  - Name of Storage Location.
- geographicLocation: System.String
  - Geographic Location of Store.
- backupCount: System.Int32
  - Count of backups stored in storage location.
- spaceConsumedBytes: System.Int64
  - Space consumed on storage location.
- connectionParameters: MosaicStoreConnectionParameters
  - Various parameters used for connecting with store.
- storeConnectionStatus: MosaicStoreConnectionStatus
  - Connection Status of Mosaic with Store.
- storeType: MosaicStoreType
  - Type of Mosaic Store.
