### PatchMongoSourceInput
Input for patching a MongoDB source.

- mongoSourcePatchRequestConfig: MongoSourcePatchRequestConfigInput
  - Required. v8.1-v9.2: The request object containing parameters like username, password, which are to be edited for a MongoDB source on the Rubrik cluster.
v9.3+: The request object containing parameters like username, password, or the list of nodes to ignore for backup to be edited for a MongoDB source on the Rubrik cluster.
- id: System.String
  - Required. v8.1-v9.2: ID of the MongoDB source.
v9.3+: Managed ID of the MongoDB source.
