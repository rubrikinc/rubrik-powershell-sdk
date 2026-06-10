### FailoverGroupArchivalLocation
Information about an archival location in a failover group.

- sourceLocationId: System.String
  - Source cluster archival location ID.
- sourceLocationName: System.String
  - Source cluster archival location name.
- sourceLocationStatus: ArchivalLocationStatus
  - Source cluster archival location status.
- targetLocationId: System.String
  - Target cluster archival location ID.
- targetLocationName: System.String
  - Target cluster archival location name.
- targetLocationStatus: ArchivalLocationStatus
  - Target cluster archival location status.
- targetLastRefreshTime: DateTime
  - Target cluster last refresh time.
- sourceLocationType: TargetType
  - Source archival location type (e.g. AWS, Azure, GCP).
- sourceStorageLocation: System.String
  - Source storage location display string (e.g. bucket name, container).
- isSourceImmutabilityEnabled: System.Boolean
  - Whether immutability is enabled on source location.
- targetLocationType: TargetType
  - Target archival location type (e.g. AWS, Azure, GCP).
- targetStorageLocation: System.String
  - Target storage location display string (e.g. bucket name, container).
- isTargetImmutabilityEnabled: System.Boolean
  - Whether immutability is enabled on target location.
