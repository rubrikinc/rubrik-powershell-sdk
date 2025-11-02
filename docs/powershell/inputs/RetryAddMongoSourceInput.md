### RetryAddMongoSourceInput
Input for putting a MongoDB source.

- mongoSourceRequestConfig: MongoSourceAddRequestConfigInput
  - Required. The request object containing parameters like username, password, and a list of hosts required to add a MongoDB source to the Rubrik cluster.
- id: System.String
  - Required. v8.1-v9.2: ID of the MongoDB source.
v9.3+: Managed ID of the MongoDB source.
