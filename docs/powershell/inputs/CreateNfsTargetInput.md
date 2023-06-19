### CreateNfsTargetInput
Input to create the NFS archival location.

- clusterUuid: System.String
  - Cluster UUID of the NFS archival location.
- name: System.String
  - Name of the NFS archival location.
- host: System.String
  - Host IP address of the NFS archival location.
- exportDir: System.String
  - Export directory of the NFS archival location.
- nfsVersion: System.Int32
  - Version of the NFS archival location.
- nfsAuthType: AuthTypeEnum
  - Authentication type of the NFS archival location.
- otherNfsOptions: System.String
  - Other options of the NFS archival location.
- fileLockPeriodInSeconds: System.Int32
  - File lock period in seconds of the NFS archival location.
- destinationFolder: System.String
  - Destination folder of the NFS archival location.
- isConsolidationEnabled: System.Boolean
  - Flag to determine if consolidation is enabled in the NFS archival location.
- encryptionPassword: System.String
  - Encryption password for the NFS archival location.
