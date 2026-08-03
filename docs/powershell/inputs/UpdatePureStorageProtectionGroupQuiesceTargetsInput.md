### UpdatePureStorageProtectionGroupQuiesceTargetsInput
Input for replacing the persisted quiesce-target selection of a Pure Storage protection group.

- id: System.String
  - Required. ID of the Pure Storage protection group.
- updateRequest: UpdateQuiesceTargetsRequestInput
  - Required. The full replacement list of quiesce targets to persist on the protection group.
