### PutOpsManagerManagedMongoSourceInput


- id: System.String
  - Required. v9.2: The ID of the MongoDB source to be updated.
      v9.3+: The managed ID of the MongoDB source to be updated.
- mongoOpsmanagerSourceUpdateRequestConfig: MongoOpsManagerSourceAddRequestConfigInput
  - Required. v9.2: The request object containing parameters like Project ID, Cluster ID, API Token, and a list of OpsManager nodes required to add the MongoDB source to the Rubrik cluster. v9.3: The request object containing parameters like the Group (project) ID, Cluster ID, API Token, and a list of OpsManager nodes required to add the MongoDB source to the Rubrik cluster.
