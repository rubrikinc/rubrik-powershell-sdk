### FusionComputeVirtualDisk
A virtual disk attached to a FusionCompute virtual machine.

- sequenceNum: System.Int32
  - Sequence number (boot order index) of the disk.
- volumeUrn: System.String
  - Unique resource name of the volume.
- volumeUuid: System.String
  - UUID of the volume.
- datastoreUrn: System.String
  - URN of the datastore where the disk resides.
- quantityGb: System.Int64
  - Provisioned size of the disk in GB.
- diskName: System.String
  - Display name of the disk (e.g., "i-0000000D-vda").
- volumeUrl: System.String
  - URL path to the volume image file.
- isThin: System.Boolean
  - Whether the disk is thin provisioned.
- indepDisk: System.Boolean
  - Whether the disk is an independent disk (not affected by snapshots).
