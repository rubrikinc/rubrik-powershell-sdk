### CreateTapeReaderTargetInput
Input for creating a Tape reader target.

- clusterUuid: System.String
  - Field for specifying the cluster UUID for the archival location.
- name: System.String
  - Name of the reader Tape archival location.
- hostName: System.String
  - IP address of the QStar server of the reader Tape archival location.
- hostPort: System.Int32
  - Port of the QStar server for the reader Tape archival location.
- integralVolumeName: System.String
  - Integral volume for the reader Tape archival location.
- destinationFolderName: System.String
  - Destination folder name for the reader Tape archival location.
- username: System.String
  - Username for the reader Tape archival location.
- password: System.String
  - User password for the reader Tape archival location.
- encryptionPassword: System.String
  - Encryption password for the reader Tape archival location.
- readerRetrievalMethod: ReaderRetrievalMethod
  - Field for specifying the metadata to be retrieved from a target.
- archivalDataSourceIds: list of System.Strings
  - List of workload IDs on the original Rubrik cluster. This list should be empty for a full refresh.
