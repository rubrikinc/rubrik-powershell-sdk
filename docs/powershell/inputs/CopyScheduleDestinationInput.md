### CopyScheduleDestinationInput
Destination of the copy schedule; exactly one must be set.
- NAS share targets: set destination_share_id to the unique identifier
of a NAS share already onboarded to NAS Cloud Direct.
- Cloud targets: set cloud_target to the inline cloud destination
configuration.

- destinationShareId: System.String
  - Destination share ID is the unique identifier of the NAS Cloud Direct
NAS share used as the copy destination for NAS-to-NAS schedules.
- cloudTarget: CopyScheduleCloudTargetInput
  - Cloud target is the inline cloud destination configuration.
