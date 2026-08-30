### HarmfulLifecyclePolicy
A customer-managed lifecycle rule that would tier files to offline tier or
delete Rubrik-owned objects at an archival location.

- ruleId: System.String
  - The identifier of the lifecycle rule, as reported by the cloud
provider. It is unique within a location.
- locationType: TargetType
  - The location type of the archival location.
- locationId: System.String
  - The unique identifier of the archival location.
- locationName: System.String
  - The name of the archival location.
- bucketName: System.String
  - The bucket holding the archived data.
- region: System.String
  - The cloud region of the archival location.
- defaultStorageClass: System.String
  - The storage class the location's objects are written to.
