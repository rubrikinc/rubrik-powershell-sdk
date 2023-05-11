### ActivitySeriesFilterInput
Filter event series data.

- ancestorId: System.String
  - Ancestor ID of the object.
- cluster: CommonClusterFilterInput
  - Cluster ID and type.
- lastActivityStatus: a list of ActivityStatusEnums
  - Status of the last event in the event series.
- lastActivityType: a list of ActivityTypeEnums
  - Type of the last event in the event series.
- lastUpdatedGt: DateTime
  - Last updated time greater than.
- lastUpdatedLt: DateTime
  - Last updated time less than.
- objectFids: a list of System.Strings
  - Forever IDs of objects.
- objectName: System.String
  - Name of the object.
- objectType: a list of ActivityObjectTypeEnums
  - Object type.
- searchTerm: System.String
  - Text to search event content.
- severity: a list of ActivitySeverityEnums
  - Severity of the event series.
- startTimeGt: DateTime
  - Start time greater than.
- startTimeLt: DateTime
  - Start time less than.
