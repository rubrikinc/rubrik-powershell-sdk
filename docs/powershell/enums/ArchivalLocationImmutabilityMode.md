### ArchivalLocationImmutabilityMode
Immutability mode for an archival location. Present only for NAS CloudDirect targets.

- COMPLIANCE - Compliance mode. Locked objects cannot be deleted or modified by any user, including the root user, until the lock duration elapses.
- GOVERNANCE - Governance mode. Locked objects are protected, but users with appropriate privileges can override or remove the lock before the duration elapses.
