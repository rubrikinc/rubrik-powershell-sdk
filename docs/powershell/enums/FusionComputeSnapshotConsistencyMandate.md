### FusionComputeSnapshotConsistencyMandate
Consistency level mandated for this FusionCompute virtual machine.

- FUSION_COMPUTE_SNAPSHOT_CONSISTENCY_MANDATE_AUTOMATIC - Pre-check VSS health and request a consistency snapshot when healthy; fall back to a crash-consistent snapshot otherwise. The default behavior.
- FUSION_COMPUTE_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT - Always take a crash-consistent snapshot. Skip the VSS pre-check.
- FUSION_COMPUTE_SNAPSHOT_CONSISTENCY_MANDATE_APPLICATION_CONSISTENT - Always request an application-consistent (VSS-quiesced) snapshot; surface failures rather than falling back to crash-consistent.
