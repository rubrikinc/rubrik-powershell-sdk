### DcRecoveryMethod
DcRecoveryMethod specifies the recovery method for a DC.

- DC_RECOVERY_METHOD_UNSPECIFIED - Unspecified recovery method (default zero value, hidden from GraphQL).
- DC_RECOVERY_METHOD_SYSTEM_STATE - Perform system state recovery.
- DC_RECOVERY_METHOD_BARE_METAL - Perform Bare Metal Recovery (BMR).
- DC_RECOVERY_METHOD_APPLICATION_ONLY - Perform Application-Only recovery (AD-Domain-Services reinstall +
promote + restore from snapshot, without bare-metal/system-state).
Requires dsrmPassword on DomainControllerRecoveryInput.
Requires CDM cluster v9.6+.
