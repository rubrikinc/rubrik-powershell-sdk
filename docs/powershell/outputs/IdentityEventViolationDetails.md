### IdentityEventViolationDetails
Identity event level violation details.

- eventTime: DateTime
  - Time of the origin event.
- eventType: LambdaEventType
  - Origin event type.
- sourceIdentityId: System.String
  - Source identity ID.
- targetIdentityDetails: IdentityInfo
  - Target identity details. In the case of a group membership add/remove
event, the target is the user being added/removed from the group.
- sourceIdentityDetails: IdentityInfo
  - Source identity details. In the case of a group membership add/remove
event, the source is the group that the user is being added/removed from.
- gpoStatus: GpoStatus
  - GPO status.
- actorIdentityId: System.String
  - Identity ID of the actor.
- actorIdentityDetails: IdentityInfo
  - Actor identity details.
- revertStatus: RemediationState
  - Status of the revert remediation.
