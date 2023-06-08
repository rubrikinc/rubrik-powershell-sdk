### AddMongoSourceInput
Input for adding a MongoDB source.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- mongoSourceAddRequestConfig: MongoSourceAddRequestConfigInput
  - Required. The request object containing parameters like username, password, and a list of hosts required to add the MongoDB source to the Rubrik cluster.
