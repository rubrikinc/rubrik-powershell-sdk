### CopyScheduleTargetType
CopyScheduleTargetType is the destination category for a copy schedule.
UI clients rely on the enum to list the fixed set of choices. The value
forwarded to the NCD cluster is the enum name with the
COPY_SCHEDULE_TARGET_TYPE_ prefix stripped (e.g. CLOUD, NAS_SHARE).

- COPY_SCHEDULE_TARGET_TYPE_UNSPECIFIED - Unset target type; rejected at validation.
- COPY_SCHEDULE_TARGET_TYPE_CLOUD - Cloud object-store destination (configured via the cloudTarget object).
- COPY_SCHEDULE_TARGET_TYPE_NAS_SHARE - NAS share destination (selector carried in destinationShareId).
