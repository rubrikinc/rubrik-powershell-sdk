### CreateGlacierReaderTargetInput
Input for creating a new Glacier reader target.

- cloudAccountId: System.String
  - Cloud account ID.
- clusterUuid: System.String
  - Cluster UUID of the target.
- encryptionPassword: System.String
  - Field for specifying a password for encrypting the Glacier location contents.
- name: System.String
  - Name of the target.
- readerRetrievalMethod: ReaderRetrievalMethod
  - Field for specifying the metadata to be retrieved from a target.
- region: AwsRegion
  - Region of the target.
- retrievalTier: AwsRetrievalTier
  - Retrieval tier for this target.
- vaultName: System.String
  - Amazon Glacier vault name.
