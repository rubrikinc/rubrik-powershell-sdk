### ClusterNodeStatus
Represents the status of the node in a Rubrik cluster.

- WARNING - Node needs attention. Either the node is down, or some of the disks on the node are unavailable.
- MAINTENANCE - Node is down for maintenance.
- BOOTSTRAPPING - Node is being bootstrapped with the Rubrik cluster. This state precedes the OK state and the node services will not be functional until the node transitions to status OK.
- BAD - Node is unhealthy.
- REMOVED - Node has been removed from the cluster.
- OK - Node is healthy and normal operation is expected.
- JOINING - Node is joining the cluster.
- UPGRADE - Node is being upgraded. The node will not accept any new jobs and the upgrade operation will begin after existing jobs are completed.
- PRE_MAINTENANCE - Node is being taken down for maintenance. After all sanity checks, the node status will change to MAINTENANCE state.
- UNKNOWN - Node status is not known.
