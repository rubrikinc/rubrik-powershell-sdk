### SigninAnomalyMetadata
Metadata for a sign-in anomaly violation. The subject is the target that had
the sign-in failure spike, and the actors are the identities attributed to the
changes behind the anomaly.

- displayName: System.String
  - Display name of the target.
- principalType: ViolationPrincipalType
  - Type of the target principal.
- idpType: IdpType
  - Identity provider of the target. Always Microsoft Entra ID for sign-in anomaly detection.
- domainName: System.String
  - The domain or tenant the target belongs to.
- domainUniqueId: System.String
  - Stable identifier of the domain or tenant the target belongs to.
- uniqueId: System.String
  - Stable unique identifier of the target.
- actors: list of SigninAnomalyActors
  - Identities attributed to the target changes behind this sign-in anomaly.
- detectedOn: DateTime
  - The time the sign-in anomaly was first detected.
- lastSeen: DateTime
  - The time of the most recent observation of the sign-in anomaly.
- creationTime: DateTime
  - The time the target was created. Empty when this information is unavailable.
