# New-RscQueryVmware
## Subcommands
### cdpstateinfos
Batch get vsphere vmware cdp state infos.

- There is a single argument of type list of System.Strings.
- Returns list of VmwareCdpStateInfos.
### ismanagementenabled
- The ismanagementenabled subcommand takes no arguments.
- Returns System.Boolean.
### missedrecoverableranges
Get missed time ranges for point in time recovery

Supported in v5.1+
Gets a list of time ranges to which a CDP-enabled virtual machine cannot perform a point-in-time recovery. The time ranges are indicated by start and end timestamps listed as date-time strings.

- There is a single argument of type VmwareMissedRecoverableRangesInput.
- Returns VmwareRecoverableRangeListResponse.
### recoverableranges
Get available time ranges for point in time recovery

Supported in v5.1+
Gets time ranges available for point-in-time recovery. The time ranges are indicated by start and end date-time strings.

- There is a single argument of type VmwareRecoverableRangesInput.
- Returns VmwareRecoverableRangeListResponse.
### vmsrecoverypermissioncheck
Get information about whether or not a user can recover specific VMware virtual machines.

- There is a single argument of type CheckVmwareVmsRecoveryPermissionInput.
- Returns CheckVmwareVmsRecoveryPermissionReply.
