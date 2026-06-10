### PostgresHaReplicaConfigRole
User-intended role hint for a replica in an HA PostgreSQL cluster. PRIMARY identifies the writable primary; STANDBY identifies a read-only standby. Used as the initial seeded role - discovery confirms or corrects the actual role at runtime.

- POSTGRES_HA_REPLICA_CONFIG_ROLE_PRIMARY
- POSTGRES_HA_REPLICA_CONFIG_ROLE_STANDBY
