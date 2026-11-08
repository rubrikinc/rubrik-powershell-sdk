### AccountResourceGraphNode
AccountResourceGraphNode is one resource in the account-wide dependency
graph. The resource type is hoisted to the enclosing AccountResourceGroup
to save payload space.

- autoId: System.String
  - Response-local numeric ID of the resource. Config resources use their
stored auto ID; workloads receive sequential IDs after the largest config
auto ID. Not stable across calls; use uri to reference a resource.
- uri: System.String
  - The resource's AWS ARN. Pass it unchanged in an application's resource
inclusion or exclusion list. A launch template version has no ARN of its
own, so its uri is the template ARN with the version appended after a
colon.
- name: System.String
  - Display name of the resource.
- isTagged: System.Boolean
  - Whether the resource matches any of the requested tags.
- relatedResourceIds: list of System.Strings
  - Auto IDs of the resources this resource is connected to.
