### AzureLocalIpPool
One contiguous IP address pool within an Azure Local logical network subnet.
Pools are only present on Static logical networks.

- start: System.String
  - First IP address in the pool, e.g. "10.1.212.10".
- end: System.String
  - Last IP address in the pool, e.g. "10.1.212.200".
- available: System.Int64
  - Number of unallocated IP addresses remaining in this pool.
