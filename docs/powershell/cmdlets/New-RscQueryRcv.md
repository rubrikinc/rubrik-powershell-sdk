# New-RscQueryRcv
## Subcommands
### accountentitlement
Rubrik Cloud Vault (RCV) Account entitlement details.

- The accountentitlement subcommand takes no arguments.
- Returns RcvAccountEntitlement.
### accountentitlements
Rubrik Cloud Vault (RCV) account entitlements with their respective order numbers.

- The accountentitlements subcommand takes no arguments.
- Returns AllRcvAccountEntitlements.
### istriggergrstprconfigured
Verify whether the trigger RCV GRS failover quorum authorization policy is set.

- The istriggergrstprconfigured subcommand takes no arguments.
- Returns System.Boolean.
### migrationinfo
Gets migration related information for a location undergoing conversion
to an RCV location.

- There is a single argument of type System.String.
- Returns list of PerLocationMigrationInfos.
### privateendpointconnections
Get private endpoint connection approval request.

- There is a single argument of type System.String.
- Returns list of DetailedPrivateEndpointConnections.
