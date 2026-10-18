### RecoverMongoClusterInput
Input for cluster-level MongoDB recovery.

- userNote: System.String
  - User note to associate with audits.
- input: MongoClusterRecoveryRequestConfigInput
  - Required. The MongoDB cluster-level recovery request object containing the database or collection objects to be recovered from the source to the target MongoDB cluster along with cluster-recovery config details.
