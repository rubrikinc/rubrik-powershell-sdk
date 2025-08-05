### CreateGlacierReaderTargetInput
Input for creating a new Glacier reader target.

- name: System.String
  - Name of the target.
- cloudAccountId: System.String
  - Cloud account ID.
- vaultName: System.String
  - Amazon Glacier vault name.
- region: AwsRegion
  - Region of the target.
- encryptionPassword: System.String
  - Field for specifying a password for encrypting the Glacier location contents.
- clusterUuid: System.String
  - Cluster UUID of the target.
- retrievalTier: AwsRetrievalTier
  - Retrieval tier for this target.
- readerRetrievalMethod: ReaderRetrievalMethod
  - Field for specifying the metadata to be retrieved from a target.
- archivalDataSourceIds: list of System.Strings
  - List of workload IDs on the original Rubrik cluster. This list should be empty for a full refresh.
