### UpdateQuiesceTargetsRequestInput
Supported in v9.6+
Request body for the quiesce-target selection PATCH. The list is a full replacement (not a partial merge); send an empty list to clear the persisted selection.

- targets: list of QuiesceTargetInputs
  - Required. Supported in v9.6+
The full replacement list of quiesce targets to persist on the protection group. Maximum of 100 entries.
