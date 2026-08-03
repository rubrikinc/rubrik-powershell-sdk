### MariadbSlaConfig
SLA Domain configuration for MariaDB.

- logFrequency: Duration
  - Frequency value for the log backup of MariaDB instances.
- logRetention: Duration
  - Specifies the duration for which the MariaDB instance logs will be retained.
- differentialFrequency: Duration
  - Optional frequency value for the differential backup of MariaDB instances.
- differentialRetention: Duration
  - Optional duration for which the MariaDB differential backup is retained.
