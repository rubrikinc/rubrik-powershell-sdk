### PatchOpsManagerManagedMongoSourceInput


- id: System.String
  - Required. v9.2: ID of the MongoDB source.
v9.3+: Managed ID of the MongoDB source.
- userNote: System.String
  - Required. User note to associate with audits.
- patch: MongoOpsManagerSourcePatchRequestConfigInput
  - Required. v9.2: The request object containing parameters like the API token and ignored nodes, which are to be edited for a MongoDB source on the Rubrik cluster. v9.3: The request object containing parameters like API Token and ignored nodes, which are to be edited for a MongoDB source on the Rubrik cluster.
