### CheckClusterRuSupportReply
Response for CheckClusterRuSupport.

- clusterUuid: System.String
  - Cluster UUID.
- isRuSupported: System.Boolean
  - Whether the cluster supports Rolling Upgrade (RU).
False if any supportability check fails.
- ruUnsupportabilityReason: System.String
  - Reason why the cluster does not support Rolling Upgrade.
Contains details about the failed supportability check.
Empty string if cluster supports RU.
