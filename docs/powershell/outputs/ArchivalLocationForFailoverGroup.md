### ArchivalLocationForFailoverGroup
Information about the eligibility of adding an archival location
to a failover group.

- id: System.String
  - Archival location ID.
- name: System.String
  - Name of the archival location.
- locationType: TargetType
  - Type of the archival location.
- locationStatus: ArchivalLocationStatus
  - Status of the archival location (READ_WRITE, READ_ONLY, etc).
- storageLocation: System.String
  - Storage location display string (e.g. bucket name, container).
- isImmutabilityEnabled: System.Boolean
  - Whether immutability is enabled for this location.
- isEligible: System.Boolean
  - Whether the location is eligible for adding to a failover
group.
- ineligibilityReason: ArchivalLocationIneligibilityReason
  - Reason why the location is ineligible (if not eligible).
