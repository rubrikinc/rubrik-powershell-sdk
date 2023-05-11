### FailoverClusterAppSourceInput
Supported in v5.2+

- nodeOrders: a list of FailoverClusterNodeOrderInputs
  - Supported in v5.2+
      Specifies an order for the failover cluster nodes. Failover cluster app backups use the failover cluster nodes in the specified order.
- vips: a list of System.Strings
  - Virtual IP addresses of the failover cluster.
- virtualIps: a list of System.Strings
  - Supported in v5.3+
      Virtual IP addresses of the failover cluster.
