### SaasActivityViolationDetails
Violation details for SaaS activity policy violations. Each violation
corresponds to a single SaaS activity event. The actor is identified
by email address.

- actorEmail: System.String
  - Email of the actor that performed the activity. Empty when the source
event carries no actor.
- activityType: System.String
  - Type of the activity, as reported by the SaaS provider.
- eventCreatedAt: DateTime
  - Time the activity occurred at the SaaS provider.
- activityId: System.String
  - Provider-assigned unique identifier of the activity.
- actorType: System.String
  - Type of the actor that performed the activity (for example, "user" or
"api").
- rscOrgId: System.String
  - RSC organization the activity belongs to.
