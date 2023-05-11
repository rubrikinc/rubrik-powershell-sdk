### CreateNfsReaderTargetInput
Input for creating a NFS Reader Target.

- clusterUuid: System.String
  - Field for specifying cluster UUID of the target.
- destinationFolder: System.String
  - Field for specifying destination folder of the NFS.
- encryptionPassword: System.String
  - Field for specifying the encryption password.
- exportDir: System.String
  - Field for specifying the exported directory at the host of the NFS location.
- fileLockPeriodInSeconds: System.Int32
  - Field for specifying file lock period, in seconds.
- host: System.String
  - Field for specifying the host of the NFS location.
- isConsolidationEnabled: System.Boolean
  - Field for whether consolidation should be enabled or not for this target.
- name: System.String
  - Field for specifying name of the target.
- nfsAuthType: AuthTypeEnum
  - Field for specifying the authentication type of NFS.
- nfsVersion: System.Int32
  - Field for specifying the version of NFS.
- otherNfsOptions: System.String
  - Field for specifying other NFS options.
- readerRetrievalMethod: ReaderRetrievalMethod
  - Field for specifying the metadata to be retrieved from a target.
