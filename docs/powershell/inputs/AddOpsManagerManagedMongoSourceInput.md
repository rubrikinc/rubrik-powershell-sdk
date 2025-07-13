### AddOpsManagerManagedMongoSourceInput


- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- mongoOpsmanagerSourceAddRequestConfig: MongoOpsManagerSourceAddRequestConfigInput
  - Required. v9.2: The request object containing parameters like Project ID, Cluster ID, API Token, and a list of OpsManager nodes required to add the MongoDB source to the Rubrik cluster. v9.3: The request object containing parameters like the Group (project) ID, Cluster ID, API Token and a list of OpsManager nodes required to add the MongoDB source to the Rubrik cluster.
