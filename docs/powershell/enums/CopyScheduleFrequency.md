### CopyScheduleFrequency
CopyScheduleFrequency is the cadence unit for a copy schedule. UI clients
rely on the enum to list the fixed set of choices. The value forwarded to
the NCD cluster is the enum name with the COPY_SCHEDULE_FREQUENCY_ prefix
stripped (e.g. DAILY, WEEKLY). Every member is a cadence an NCD cluster can
actually run; tags 5 and 6 are reserved for two that it cannot.

- COPY_SCHEDULE_FREQUENCY_UNSPECIFIED - Unset frequency; rejected at validation.
- COPY_SCHEDULE_FREQUENCY_HOURLY - Run every frequencyValue hours.
- COPY_SCHEDULE_FREQUENCY_DAILY - Run every frequencyValue days.
- COPY_SCHEDULE_FREQUENCY_WEEKLY - Run every frequencyValue weeks (see dayOfWeek).
- COPY_SCHEDULE_FREQUENCY_MONTHLY - Run every frequencyValue months (see dayOfMonth).
