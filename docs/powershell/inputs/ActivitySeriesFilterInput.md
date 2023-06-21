### ActivitySeriesFilterInput
Filter event series data.

- lastActivityStatus: list of ActivityStatusEnums
  - Status of the last event in the event series.
- lastActivityType: list of ActivityTypeEnums
  - Type of the last event in the event series.
- severity: list of ActivitySeverityEnums
  - Severity of the event series.
- objectName: System.String
  - Name of the object.
- objectType: list of ActivityObjectTypeEnums
  - Object type.
- startTimeGt: DateTime
  - Start time greater than.
- startTimeLt: DateTime
  - Start time less than.
- lastUpdatedGt: DateTime
  - Last updated time greater than.
- lastUpdatedLt: DateTime
  - Last updated time less than.
- cluster: CommonClusterFilterInput
  - Cluster ID and type.
- objectFids: list of System.Strings
  - Forever IDs of objects.
- ancestorId: System.String
  - Ancestor ID of the object.
- searchTerm: System.String
  - Text to search event content.
