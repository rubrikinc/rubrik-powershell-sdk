### AppAccessPath
Describes the access path that changed as a result of the event.

- pathType: AccessPathType
  - Whether the path is direct (user -> app) or indirect (user -> group -> app).
- groupId: System.String
  - Group ID for indirect paths. Empty for direct paths.
- groupName: System.String
  - Group display name for indirect paths. Empty for direct paths.
