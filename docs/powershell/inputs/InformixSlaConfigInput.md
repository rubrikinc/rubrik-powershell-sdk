### InformixSlaConfigInput
Input to configure the SLA Domain for Informix.

- incrementalFrequency: SlaDurationInput
  - Frequency value for the incremental backup of Informix instances.
- incrementalRetention: SlaDurationInput
  - Specifies the duration for which the Informix instance incremental backup is retained.
- logFrequency: SlaDurationInput
  - Frequency value for the log backup of Informix instances.
- logRetention: SlaDurationInput
  - Specifies the duration for which the Informix instance logs is retained.
