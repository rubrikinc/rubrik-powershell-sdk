### ManagedObjectSummary
Managed object summary.

- id: System.String
  - ID of the managed object.
- name: System.String
  - Name of the managed object.
- objectType: ManagedObjectType
  - Type of the managed object.
- slaDomain: SlaDomainSummary
  - Details of the SLA Domain to which the managed object belongs.
- snapshotsDetails: list of SnapshotDetailss
  - Snapshot details.
- parentIdForConflictingAssignment: System.String
  - Optional parent object ID. This will be populated only in case of conflicting SLA assignment, that is, when this object will start inheriting the new SLA Domain of the parent, instead of retaining it's direct assignment.
