### IgnoreClusterRemovalPrecheckReply
Information regarding the ability to ignore cluster removal prechecks.

- isDisconnected: System.Boolean
  - Whether the cluster is disconnected.
- lastConnectionTime: DateTime
  - The time when the cluster was last found to be connected.
- ignorePrecheckTime: DateTime
  - Timestamp when the cluster removal precheck can be ignored. This is calculated based on the last connection time. Cluster removal precheck can be ignored if the cluster is disconnected for more than 7 days.
- canIgnorePrecheck: System.Boolean
  - Specifies whether the cluster removal precheck can be ignored.
- isAirGapped: System.Boolean
  - Specifies whether the cluster is air-gapped.
