### AccountResourceGroup
AccountResourceGroup buckets nodes by resource type, so the type is not
repeated per node.

- type: ConfigResourceType
  - Resource type shared by every node in the group.
- nodes: list of AccountResourceGraphNodes
  - Resources of this type.
