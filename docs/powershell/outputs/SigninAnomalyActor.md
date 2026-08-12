### SigninAnomalyActor
One identity attributed to a target change behind a sign-in anomaly.

- eventId: System.String
  - The audit-log event ID of the target change.
- actorId: System.String
  - The actor's principal ID. The display name and type are resolved on a best-effort basis and are empty when the actor cannot be resolved.
- actorName: System.String
  - The actor's display name. Empty when the actor cannot be resolved.
- actorType: ViolationPrincipalType
  - The actor's principal type. Empty when the actor cannot be resolved.
- actorIp: System.String
  - The actor's source IP address for the target change. Empty when no IP address is available.
