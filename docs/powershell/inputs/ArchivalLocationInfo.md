### ArchivalLocationInfo
ArchivalLocationInfo is message definition for archival
 polling operations (`ARCHIVAL_LOCATION`). It contains fields required
 for archival job polling operations.

- polarisManagedLocId: System.String
  - ID of location.
- locationName: System.String
  - Name of the location.
- locationType: System.String
  - Type of the location.
- operationType: ArchivalLocationOperationType
  - Type of operation.
- operationId: System.String
  - Operation ID is used to group together multiple events emitted as part of
 the same user action, and separate events emitted by different actions on
 the same archival location. When a customer performs an action, such as
 editing a location, a unique OperationID` is generated which is used to
 group any events emitted by that operation in the UI and also distinguish
 it from other customer actions.
