### DomainControllerRecoveryInput
DomainControllerRecoveryInput contains configuration for recovering a single DC.
Note: domain_sid and credentials are inherited from the parent DomainRecoveryInput.

- snapshotId: System.String
  - Snapshot ID to use for recovery (UUID).
- altHostId: System.String
  - Alternate host ID (optional, UUID).
If provided, DC will be recovered to this alternate host.
- recoveryMethod: DcRecoveryMethod
  - Recovery method for this DC.
- unselectedDcBehavior: UnselectedDcBehavior
  - Behavior for DCs in the same domain that are not selected for recovery.
- networkInterfaceSetting: NetworkInterfaceSetting
  - Network interface setting for IP address retention.
Uses cdmrestservice.NetworkInterfaceSetting enum.
- dsrmPassword: System.String
  - DSRM (Directory Services Restore Mode) admin password.
Required when recoveryMethod is DC_RECOVERY_METHOD_APPLICATION_ONLY,
ignored otherwise.
