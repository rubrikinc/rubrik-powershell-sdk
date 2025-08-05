### CreateRcsReaderTargetInput
Input for creating a RCS Reader Target.

- clusterUuid: System.String
  - Field for specifying cluster UUID of the target.
- readerLocationName: System.String
  - Field for specifying the name of reader location for RCS.
- rcsArchivalLocationName: System.String
  - Field for specifying the name of original reader location to which to connect as Reader.
- readerRetrievalMethod: ReaderRetrievalMethod
  - Field for specifying the metadata to be retrieved from a target.
- archivalDataSourceIds: list of System.Strings
  - List of workload IDs on the original Rubrik cluster. This list should be empty for a full refresh.
