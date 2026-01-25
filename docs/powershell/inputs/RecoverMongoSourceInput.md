### RecoverMongoSourceInput
Input for recovering MongoDB databases and collections.

- input: MongoRecoveryRequestConfigInput
  - Required. v9.0-v9.2: The MongoDB recovery request object containing the collection objects to be recovered from source to the target MongoDB cluster.
v9.3+: The MongoDB recovery request object containing the database or collection objects to be recovered from the source to the target MongoDB cluster.
- userNote: System.String
  - User note to associate with audits.
