### LegalHoldInfo
Contains information about the legal hold placed on the Snapshot.

- shouldHoldInPlace: System.Boolean
  - Boolean which describes whether snapshot has to be held in place.
- holdReplica: System.Boolean
  - RSC native only. When true, the legal hold extends to all replica copies of the source snapshot. When false, only the source copy is held and replica copies remain deletable. Always false for CDM/NCD (CDM controls replica retention via SLA on the cluster).
