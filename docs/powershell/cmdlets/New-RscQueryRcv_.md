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
### clusterlocations
List Rubrik Cloud Vault locations of the cluster.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
- Returns RcvLocationBasicInfoConnection.
### customerzonesdetailslist
Specifies the RCV zone, redundancy, and corresponding details.

- The customerzonesdetailslist subcommand takes no arguments.
- Returns CustomerRcvZonesDetails.
### privateendpointconnections
Get private endpoint connection approval request.

- There is a single argument of type System.String.
- Returns list of DetailedPrivateEndpointConnections.
### readerownerencryptionkey
Get reader RCV archival target's owner encryption key.

- There is a single argument of type QueryRCVReadersOwnerEncryptionKeyInput.
- Returns QueryRCVReadersOwnerEncryptionKeyReply.
### regions
List of Azure RCV regions based on bundle and tier.

- There is a single argument of type list of GetRCVRegionsFilters.
- Returns GetRCVRegionsReply.
