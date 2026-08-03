### SnapshotTypeEnum
Snapshot type enum.

- SCHEDULED - Snapshot taken automatically on the SLA Domain's schedule.
- ON_DEMAND - Snapshot triggered manually by a user, outside the SLA schedule.
- DOWNLOADED - Downloaded is ideally a customization. However, legacy behaviour is
to treat it as a type. We are keeping it for now since there are
multiple workflows still using this. This field should be deprecated
once we modify all workflows to use downloaded as a customization rather
than a workflow.
