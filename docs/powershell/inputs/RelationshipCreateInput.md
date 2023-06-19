### RelationshipCreateInput
Supported in v7.0+
  v7.0-v8.0: 
  v8.1+: Input to create a SnapMirror Cloud relationship.

- objectStoreAccess: ObjectStoreAccessInput
  - Supported in v7.0+
      Properties required to access the object store (cloud target) for the SnapMirrorCloud object.
- snapMirrorCloudId: System.String
  - Required. Supported in v7.0+
      v7.0-v8.0: ID of SnapMirror Cloud protected object.
      v8.1+: ID of SnapMirror Cloud workload.
