### SapHanaConfigInput
Input to configure the SLA Domain for SAP HANA database.

- incrementalFrequency: SlaDurationInput
  - Frequency value for incremental backup of SAP HANA databases.
- logRetention: SlaDurationInput
  - Specifies the duration for which the SAP HANA database logs will be retained.
- differentialFrequency: SlaDurationInput
  - Frequency value for differential backup of SAP HANA databases.
- storageSnapshotConfig: SapHanaStorageSnapshotConfigInput
  - SLA Domain config for SAP HANA Storage Snapshot.
