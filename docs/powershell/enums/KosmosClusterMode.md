### KosmosClusterMode
Whether a workload runs as a standalone instance or as part of a
high-availability (HA) cluster. Reusable across any Kosmos workload
that supports HA topologies (PostgreSQL, MySQL, MariaDB).

- UNSPECIFIED - Cluster mode could not be determined.
- STANDALONE - Workload runs as a single instance with no HA topology.
- HA - Workload participates in a high-availability cluster.
