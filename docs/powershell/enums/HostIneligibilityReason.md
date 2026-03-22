### HostIneligibilityReason
Reason why a host is ineligible for adding to a failover group.

- HOST_INELIGIBILITY_REASON_UNSPECIFIED - Unspecified ineligibility reason (proto3 default zero value).
- HOST_INELIGIBILITY_REASON_NONE - Host is eligible (no ineligibility reason).
- HOST_INELIGIBILITY_REASON_NOT_PRIMARY - Host is not a primary host (AgentPrimaryClusterUUID != primary_cluster_uuid).
- HOST_INELIGIBILITY_REASON_INVALID_PRIMARY_HOST_STATUS - Primary host has an invalid status (UNKNOWN, DISCONNECTED, DELETING,
BADLY_CONFIGURED, REMOTE, DELETION_FAILED, REPLICATED_TARGET, DELETED,
UNAUTHORIZED).
- HOST_INELIGIBILITY_REASON_NO_SECONDARY_HOST - No matching secondary host found on the secondary cluster.
- HOST_INELIGIBILITY_REASON_PRIMARY_IN_FAILOVER_GROUP - Primary host is already part of an existing failover group.
- HOST_INELIGIBILITY_REASON_SECONDARY_IN_FAILOVER_GROUP - Secondary host is already part of an existing failover group.
- HOST_INELIGIBILITY_REASON_INVALID_SECONDARY_HOST_STATUS - Secondary host has an invalid status (UNKNOWN, DISCONNECTED,
DELETING, BADLY_CONFIGURED, REMOTE, DELETION_FAILED,
REPLICATED_TARGET, DELETED, UNAUTHORIZED).
- HOST_INELIGIBILITY_REASON_NO_AGENT - Host does not have a Rubrik Backup Agent installed.
- HOST_INELIGIBILITY_REASON_UNKNOWN - Indicates an error while trying to determine the host's
eligibility.
