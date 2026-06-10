### BulkCreateFusionComputeVmBackupInput
Request for initiating on-demand backups for multiple FusionCompute virtual machines.

- ids: list of System.Strings
  - IDs of FusionCompute virtual machines to back up. Order is preserved in the
response `responses` slice; callers correlate by index, not by `Id` (which
carries the CDM async job ID).
- config: BaseOnDemandSnapshotConfigInput
  - Backup config (SLA assignment, retention) shared across all virtual machines.
