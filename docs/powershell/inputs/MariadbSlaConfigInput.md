### MariadbSlaConfigInput
Input to configure the SLA Domain for MariaDB.

- logFrequency: SlaDurationInput
  - Frequency value for the log backup of MariaDB instances.
- logRetention: SlaDurationInput
  - Specifies the duration for which the MariaDB instance logs will be retained.
- differentialFrequency: SlaDurationInput
  - Optional frequency value for the differential backup of MariaDB instances.
- differentialRetention: SlaDurationInput
  - Optional duration for which the MariaDB differential backup is retained.
