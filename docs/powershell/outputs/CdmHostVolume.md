### CdmHostVolume
A storage volume on a Rubrik CDM physical host.

- volumeId: System.String
  - Host volume's ID.
- clusterUuid: System.String
  - UUID of the Rubrik cluster that owns this volume.
- cdmId: System.String
  - Rubrik CDM ID of this volume.
- mountPoints: list of System.Strings
  - Mount points of this volume on the host.
- fileSystemType: System.String
  - File system type of this volume.
- size: System.Int64
  - Size of this volume, in bytes.
- volumeGroupId: System.String
  - ID of the volume group to which this volume belongs.
