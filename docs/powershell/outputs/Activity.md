### Activity
An activity that occurred on RSC or a Rubrik cluster.

- time: DateTime
  - The time at which this activity occurred.
- type: ActivityTypeEnum
  - The type of this activity.
- status: ActivityStatusEnum
  - The status of this activity.
- severity: ActivitySeverityEnum
  - The severity of this activity.
- message: System.String
  - The message attached to this activity.
- objectId: System.String
  - The ID of the object associated with this activity.
- objectType: ActivityObjectTypeEnum
  - The type of the object associated with this activity.
- progress: System.String
  - The current progress of this activity.
- activityInfo: System.String
  - Additional information pertaining to this activity.
- errorInfo: System.String
  - Information about the Rubrik error associated with this activity.
- id: System.String
  - The ID of the activity.
- activitySeries: ActivitySeries
  - The activity series to which this activity belongs.
- clusterId: System.String
  - The ID of the Rubrik cluster where this activity occurred.
