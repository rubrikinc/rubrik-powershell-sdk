### CreateSnapMirrorCloudRelationshipInput
Input to create a SnapMirror Cloud relationship.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- definition: RelationshipCreateInput
  - Required. v7.0-v8.0: ID of SnapMirror Cloud protected object.
      v8.1+: ID of SnapMirror Cloud workload.
