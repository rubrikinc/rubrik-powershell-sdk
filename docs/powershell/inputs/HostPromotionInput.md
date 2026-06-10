### HostPromotionInput
HostPromotionInput contains configuration for promoting a host to DC.
Note: domain_sid and credentials are inherited from the parent DomainRecoveryInput.

- hostId: System.String
  - ID of the host to promote (UUID).
- dsrmPassword: System.String
  - DSRM (Directory Services Restore Mode) password.
- ifmSnapshotId: System.String
  - Snapshot ID to use for IFM media (optional, UUID).
