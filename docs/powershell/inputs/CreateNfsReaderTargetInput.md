### CreateNfsReaderTargetInput
Input for creating a NFS Reader Target.

- name: System.String
  - Field for specifying name of the target.
- clusterUuid: System.String
  - Field for specifying cluster UUID of the target.
- host: System.String
  - Field for specifying the host of the NFS location.
- exportDir: System.String
  - Field for specifying the exported directory at the host of the NFS location.
- nfsVersion: System.Int32
  - Field for specifying the version of NFS.
- nfsAuthType: AuthTypeEnum
  - Field for specifying the authentication type of NFS.
- otherNfsOptions: System.String
  - Field for specifying other NFS options.
- fileLockPeriodInSeconds: System.Int32
  - Field for specifying file lock period, in seconds.
- destinationFolder: System.String
  - Field for specifying destination folder of the NFS.
- isConsolidationEnabled: System.Boolean
  - Field for whether consolidation should be enabled or not for this target.
- encryptionPassword: System.String
  - Field for specifying the encryption password.
- readerRetrievalMethod: ReaderRetrievalMethod
  - Field for specifying the metadata to be retrieved from a target.
- archivalDataSourceIds: list of System.Strings
  - List of workload IDs on the original Rubrik cluster. This list should be empty for a full refresh.
