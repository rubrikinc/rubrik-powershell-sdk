### ActivityEntry
This struct represents an activity.

- id: System.String
  - The unique identifier for the activity.
- time: DateTime
  - The time the activity occurred.
- activityType: LambdaEventType
  - The type of activity.
- targetEntity: ActivityAuditorEntity
  - The entity on which the activity was performed.
- actorEntity: ActivityAuditorEntity
  - The entity that performed the action (e.g., the user who made a change).
- changeDetails: ActivityAuditorChangeDetails
  - The details of the change. Present only for modification events.
- category: ActivityCategory
  - The category of the activity.
- operation: ActivityOperation
  - The operation performed.
- sourceMetadata: EventSourceMetadata
  - The metadata of the source.
- actorState: ActorIdentificationState
  - The identification state of the actor.
- activityProvider: EventProvider
  - The provider of the activity.
- primaryTargetEntity: ActivityAuditorPrimaryTargetEntity
  - The entity directly affected by the activity. For example, when a user
is added to a group, the user is the primary target.
- additionalTargetEntities: list of ActivityAuditorEntitys
  - Additional entities involved in the activity. For example, when a user is
added to a group, the group is an additional target.
- title: System.String
  - A human-readable title describing the activity. For example, in Entra ID
this is derived from the native activity display name.
- nativeCorrelationId: System.String
  - The native correlation ID from the event provider used for tracking and
grouping related activities.
- status: LambdaEventStatus
  - The result of the action.
- actionType: LambdaEventActionType
  - The action type of the activity.
- remediationStatuses: list of ActivityRemediationStatuss
  - The remediation statuses for this activity, ordered by created_at DESC.
Will be empty if no remediations exist for this activity.
- remediationTypes: list of RemediationAvailabilitys
  - The remediation types that are available for this activity.
- sourceId: System.String
  - The source (domain/tenant) of this activity.
