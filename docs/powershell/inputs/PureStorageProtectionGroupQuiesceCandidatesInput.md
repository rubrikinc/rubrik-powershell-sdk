### PureStorageProtectionGroupQuiesceCandidatesInput
Input for listing the quiesce-target candidates of a Pure Storage protection group.

- id: System.String
  - Required. ID of the Pure Storage protection group.
- limit: System.Int32
  - Maximum number of entries in the response. Defaults to 200; capped at 500 by the handler.
- offset: System.Int32
  - Starting position in the combined candidate stream. Defaults to 0.
